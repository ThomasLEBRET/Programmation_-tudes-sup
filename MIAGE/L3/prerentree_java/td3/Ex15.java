class Ex15 {
    public static void main(String[] args) {
	int[]t = new int[3];
	t[0] = 1;
	t[1] = 2;
	t[2] = 3;

	for(int i = 0; i < t.length; i++) {
	    t[i] = 0;
	    System.out.print(t[i] + " ");
	}
	System.out.println();
    }
}
