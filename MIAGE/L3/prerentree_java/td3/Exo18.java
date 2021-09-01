class Exo18 {
    public static void main(String[] args) {
        int[] t = new int[5];
        t[0] = 3;
        t[1] = 2;
        t[2] = 6;
        t[3] = 4;
        t[4] = 8;

        int min = t[0];
        for(int i = 0; i < t.length; i++) {
            if(min > t[i])
            min = t[i];
        }
        System.out.println("Le plus petit élément du tableau t est : " + min);
    }
}