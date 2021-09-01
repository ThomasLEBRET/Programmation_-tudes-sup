class Exo13 {
    public static void main(String[] args) {
        String[] nom = new String[args.length / 3];
        int[] age = new int[args.length / 3];
        int[] nbCours = new int[args.length / 3];
        int j = 0;
        for(int i = 0; i < args.length; i+=3) {
            nom[j] = args[i];
            age[j] = Integer.parseInt(args[i + 1]);
            nbCours[j] = Integer.parseInt(args[i + 2]);
            j++;
        }

        for(int i = 0; i < nom.length; i++) {
            System.out.println(nom[i] + " " + age[i] + " " + nbCours[i]);
        }
    }
}
