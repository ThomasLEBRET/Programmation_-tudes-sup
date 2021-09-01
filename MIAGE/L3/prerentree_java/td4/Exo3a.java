class Exo3a {
    static int carre(int n) {
        return n*n;
    }

    static int sommeEntiers(int n) {
        int res = 0;
        for(int i = 0; i <= n; i++) {
            res += i;
        }
        return res;
    }

    static int fact(int n) {
        if(n <= 1)
            return 1;
        else
            return n * fact(n - 1);
    }
    public static void main(String[] args) {
        int n = 6;
        System.out.println(carre(n));
        System.out.println(sommeEntiers(n));
        System.out.println(fact(n));
    }
}