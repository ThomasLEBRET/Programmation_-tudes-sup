class Exo20 {
    public static void main(String[] args) {
        int[] t = new int[6];
        t[0] = 3;
        t[1] = 2;
        t[2] = 6;
        t[3] = 4;
        t[4] = 8;
        t[5] = 5;

        int tmp = t[t.length-1];
        int min = t[0];
        int j = 0;
        for (int i  = t.length-2; i >= 0; i--){ 
            t[i+1] = t[i];
            if(t[i] < min) {
                min = t[i];
                j = i+1;
            }
        }
        t[0] = min;
        t[j] = tmp;
        
        for(int i= 0; i < t.length; i++) {
            System.out.print(t[i] + " ");
        }
        
        System.out.println();
    }
}