class Exo19 {
    public static void main(String[] args) {
        int[] t = new int[5];
        t[0] = 3;
        t[1] = 2;
        t[2] = 6;
        t[3] = 4;
        t[4] = 8;

        int tmp = t[t.length-1];

        for (int i  = t.length-2; i >= 0; i--){ 
            t[i+1] = t[i];
        }
        t[0] = tmp;
        
        for(int i= 0; i < t.length; i++) {
            System.out.print(t[i] + " ");
        }
        
        System.out.println();
    }
}