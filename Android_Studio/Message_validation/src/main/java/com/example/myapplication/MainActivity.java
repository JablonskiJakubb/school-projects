    package com.example.myapplication;

    import android.os.Bundle;
    import android.view.View;
    import android.widget.ArrayAdapter;
    import android.widget.Button;
    import android.widget.CheckBox;
    import android.widget.EditText;
    import android.widget.RadioButton;
    import android.widget.RadioGroup;
    import android.widget.Spinner;
    import android.widget.TextView;
    import android.widget.Toast;

    import androidx.activity.EdgeToEdge;
    import androidx.appcompat.app.AppCompatActivity;
    import androidx.core.graphics.Insets;
    import androidx.core.view.ViewCompat;
    import androidx.core.view.WindowInsetsCompat;


    public class MainActivity extends AppCompatActivity {

        EditText Name, Mail, Desc;
        Button Confirm;
        RadioGroup Options;
        CheckBox TOS;
        Spinner Seasons;
        @Override
        protected void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
            EdgeToEdge.enable(this);
            setContentView(R.layout.activity_main);
            ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
                Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
                v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
                return insets;
            });
            Name = findViewById(R.id.name);
            Mail = findViewById(R.id.surname);
            Desc = findViewById(R.id.desc);
            Confirm = findViewById(R.id.Confirm);
            Options = findViewById(R.id.options);
            TOS = findViewById(R.id.TOS);
            Seasons = findViewById(R.id.spinnerSeasons);
            Seasons.setAdapter(new ArrayAdapter<>(this,
                    android.R.layout.simple_spinner_item,
                    new String[]{"Wiosna", "Lato", "Jesień", "Zima"}));

            Confirm.setOnClickListener(new View.OnClickListener()
            {
                @Override
                public void onClick(View v) {
                    String nameText = Name.getText().toString();
                    String Mailtext = Mail.getText().toString();
                    String descText = Desc.getText().toString();

                    int selectedId = Options.getCheckedRadioButtonId();
                    RadioButton selectedOption = findViewById(selectedId);

                    boolean accepted = TOS.isChecked();

                    String selectedSeason = Seasons.getSelectedItem().toString();


                    if (Name.getText().toString().trim().length() < 5) {
                        Name.setError("Imię musi mieć przynajmniej 5 znaków");
                        return;
                    }
                    String email = Mail.getText().toString().trim();
                    if (!email.contains("@") || !email.contains(".")) {
                        Mail.setError("Nieprawidłowy email");
                        return;
                    }
                    descText = Desc.getText().toString().trim();
                    int lines = Desc.getLineCount(); // liczy linie
                    if (lines < 5) {
                        Desc.setError("Opis musi mieć minimum 5 linijek");
                        return;
                    }
                    if (!TOS.isChecked()) {
                        Toast.makeText(MainActivity.this, "Musisz zaakceptować regulamin", Toast.LENGTH_SHORT).show();
                        return;
                    }

                }
            });
        }

    }