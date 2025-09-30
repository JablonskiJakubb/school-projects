package threads;

class T{
	private int[] T;
	public T() {
        T = new int[50];  
    }
	public int[] getT() {
		return T;
	}
	public void wstaw(int p, int v) {
		T[p] = v;
	}
	public void wyswietl() {
		for(int i = 0; i < T.length; i++) {
			System.out.print(T[i] + " ");
		}
	}
}

public class program {

	public static void main(String[] args) {
		T t = new T();
		Thread T1 = new Thread(() -> {
			for (int i = 0; i < t.getT().length; i++) {
				t.wstaw(i, 1);
			}
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		});
		Thread T2 = new Thread(() -> {
			for (int i = t.getT().length-1; i >= 0; i--) {
				t.wstaw(i, 2);
			}
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		});
		Thread T3 = new Thread(() -> {
			t.wyswietl();
			try {
				Thread.sleep(800);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		});
		T1.start();
		T2.start();
		T3.start();

	}

}
