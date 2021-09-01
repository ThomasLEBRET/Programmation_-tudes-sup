class Exo4b {

    static String[] tabNom(String[] t) {
        String[] nom = new String[t.length/3];
        int j = 0;
        for(int i = 0; i < t.length; i+=3) {
            nom[j] = t[i];
            j++;
        }
        return nom;
    }

    static int[] tabAge(String[] t) {
        int[] age = new int[t.length/3];
        int j = 0;
        for(int i = 0; i < t.length; i+=3) {
            age[j] = 2021 - Integer.parseInt(t[i + 1]);
            j++;
        }
        return age;
    }

    static int[] tabNbCours(String[] t) {
        int[] nbCours = new int[t.length/3];
        int j = 0;
        for(int i = 0; i < t.length; i+=3) {
            nbCours[j] = Integer.parseInt(t[i + 2]);
            j++;
        }
        return nbCours;
    }
    public static void main(String[] args) {
        String[] nom = tabNom(args);
        int[] age = tabAge(args);
        int[] nbCours = tabNbCours(args);

        for(int i = 0; i < nom.length; i++) {
            System.out.println(nom[i] + " " + age[i] + " ans " + nbCours[i]);
        }
    }
}
