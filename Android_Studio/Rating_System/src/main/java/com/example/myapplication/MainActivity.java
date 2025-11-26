package com.example.myapplication;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RatingBar;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    RatingBar rating1, rating2, rating3, rating4;
    Button btnUp1, btnDown1, btnUp2, btnDown2, btnUp3, btnDown3, btnUp4, btnDown4;
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
        rating1 = findViewById(R.id.rating1);
        btnUp1 = findViewById(R.id.btnUp1);
        btnDown1 = findViewById(R.id.btnDown1);
        btnUp1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float r = rating1.getRating();
                if (r < rating1.getNumStars()) {
                    rating1.setRating(r + 0.5f);
                }
            }
        });

        btnDown1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float r = rating1.getRating();
                if (r > 0) {
                    rating1.setRating(r - 0.5f);
                }
            }
        });
        rating2 = findViewById(R.id.rating2);
        btnUp2 = findViewById(R.id.btnUp2);
        btnDown2 = findViewById(R.id.btnDown2);
        btnUp2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float r = rating2.getRating();
                if (r < rating2.getNumStars()) {
                    rating2.setRating(r + 0.5f);
                }
            }
        });

        btnDown2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float r = rating2.getRating();
                if (r > 0) {
                    rating2.setRating(r - 0.5f);
                }
            }
        });
        rating3 = findViewById(R.id.rating3);
        btnUp3 = findViewById(R.id.btnUp3);
        btnDown3 = findViewById(R.id.btnDown3);
        btnUp3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float r = rating3.getRating();
                if (r < rating3.getNumStars()) {
                    rating3.setRating(r + 0.5f);
                }
            }
        });

        btnDown3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float r = rating3.getRating();
                if (r > 0) {
                    rating3.setRating(r - 0.5f);
                }
            }
        });
        rating4 = findViewById(R.id.rating4);
        btnUp4 = findViewById(R.id.btnUp4);
        btnDown4 = findViewById(R.id.btnDown4);
        btnUp4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float r = rating4.getRating();
                if (r < rating4.getNumStars()) {
                    rating4.setRating(r + 0.5f);
                }
            }
        });

        btnDown4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float r = rating4.getRating();
                if (r > 0) {
                    rating4.setRating(r - 0.5f);
                }
            }
        });
    }
}