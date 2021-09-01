class Exo7 {
    public static void main(String[] args) {
        int[] t = new int[5];
        t[0] = 4;
        t[1] = -5;
        t[2] = 0;
        t[3] = 8;
        t[4] = -9;

        for(int i = 0; i < t.length; i++) {
            if(t[i] > 0)
                System.out.print(t[i] + " ");
        }
        System.out.println();
    }
}
