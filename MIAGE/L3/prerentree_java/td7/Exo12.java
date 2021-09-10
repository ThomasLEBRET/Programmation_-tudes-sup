class Exo12 {
    static int[][] creer(int n, int t) {
        return new int[n][t];
    }

    static void afficher(int[][] t) {
        for(int i = 0; i < t.length; i++) {
            for(int j = 0; j < t[0].length; j++) {
                System.out.print(t[i][j] + " ");
            }
            System.out.println();
        }
    }
    public static void main(String[] args) {
        int[][] t = creer(Integer.parseInt(args[0]), Integer.parseInt(args[1]));
        afficher(t);
    }
}
