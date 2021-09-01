class Ex16 {
    public static void main(String[] args) {
	int[] t = new int[3];
	t[1] = 3;
	t[2] = 7;
	t[0] = 5;

	for(int i = 0; i < t.length; i ++) {
	    System.out.print(-t[i] + " ");
	}
	System.out.println();
    }
}
