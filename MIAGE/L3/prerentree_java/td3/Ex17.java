class Ex17 {
    public static void main(String[] args) {
	int[] t = {1,2,3};
	int[] copT = new int[3];

	for(int i = 0; i < t.length; i++) {
	    System.out.print(t[i] + " ");
	    copT[t.length - 1 - i] = t[i];
	}

	System.out.println();

	for(int i = 0; i < copT.length; i++) {
	    System.out.print(copT[i] + " ");
	}

	System.out.println();
	
    }
}
