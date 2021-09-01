class Exo14 {
    public static void main(String[] args) {
        int[] t = new int[5];
        t[0] = 3;
        t[1] = 2;
        t[2] = 6;
        t[3] = 4;
        t[4] = 8;
        for(int i = 0; i < t.length; i++) {
            for(int j = 0; j < t[i]; j++) {
                System.out.print("*");
            }
            System.out.println();
        }
    }    
}
