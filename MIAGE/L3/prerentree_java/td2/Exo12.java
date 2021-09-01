class Exo12 {
    public static void main(String[] args) {
        int n;
        int i = 0;
        do {
            n = (int)Math.round(Math.random() * 10);
            i++;
        } while(n != 7);
        System.out.println(i);
    }
}
