class Exo21 {
    public static void main(String[] args) {
        int[] t = new int[5];
        t[0] = 3;
        t[1] = 2;
        t[2] = 6;
        t[3] = 4;
        t[4] = 8;
        int j = 0;
        int temp = 0;

        for(int i = 1; i < t.length - 1; i++) {
            temp = t[i];
            j = i;
            while(j > 0 && t[j - 1] > temp) {
                t[j] = t[j - 1];
                j--;
            }
            t[j] = temp;
        }
        

        for(int i= 0; i < t.length; i++) {
            System.out.print(t[i] + " ");
        }
        System.out.println();
    }
}