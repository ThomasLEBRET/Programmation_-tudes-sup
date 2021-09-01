class Exo6 {
    /* Méthode récursive */
    public static double fact(int n) {
        if(n == 0) {
            return 1;
        } 
        else {
            return n * fact(n - 1);
        }
    }
    public static void main(String[] args) {
        long res = 1; // Si on laisse en int, on dépasse la taille maximale acceptable pour un int
        for (int i = 1; i <= Integer.parseInt(args[0]); i++)
            res *= i;
        
        System.out.println(res);
        System.out.println(fact(Integer.parseInt(args[0])));
    }
}
