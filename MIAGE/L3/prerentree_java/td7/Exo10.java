class Exo10 {
    public static void main(String[] args) {
        int[][] t = { {1,2,3}, {4,5,6}, {7,8,9} };
        for(int i = 0; i < t.length; i++) {
            for(int j = t.length-i; j > 0; j--) {
                System.out.print(" ");
            }
            System.out.println(t[i][i]);
        }
    }
}
