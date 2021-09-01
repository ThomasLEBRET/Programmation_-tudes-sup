class Exo16 {
    public static void main(String[] args) {
        int n = Integer.parseInt(args[0]);
        for(int i = n; i > 0; i--) {
            for(int j = 0; j < i; j++) {
                System.out.print("*");
            }
            System.out.println();
        }
    }
}
