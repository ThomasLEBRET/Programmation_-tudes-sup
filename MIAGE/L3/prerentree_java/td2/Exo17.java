class Exo17 {
    public static void main(String[] args) {
        long res = 1; 
        for (int i = 1; i <= Integer.parseInt(args[0]); i++) {
            res = 1;
            System.out.print("Pour la valeur " + i + " : ");
            for(int j = 1; j <= i; j++) {
                res *= j;
            }
            System.out.println(res);
        }
    }
}
