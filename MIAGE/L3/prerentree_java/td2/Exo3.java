class Exo3 {
    public static void main(String[] args) {
        int total = 0;
        int n = Integer.parseInt(args[0]);
        for(int i = 0; i <= n; i++) {
            total += i;
        }

        int totalFormule = n*(n+1)/2;

        System.out.println("Sans formule : " + total + ". Avec formule : " + totalFormule);
    }
}