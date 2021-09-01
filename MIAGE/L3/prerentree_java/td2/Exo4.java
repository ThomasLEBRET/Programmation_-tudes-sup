class Exo4 {
    public static void main(String[] args) {
        int total = 0;
        int n = Integer.parseInt(args[0]);

        for(int i = 0; i <= n; i++) {
            if(i%2 != 0) {
                total += i;
            }
        }
        System.out.println(total);
    }
}