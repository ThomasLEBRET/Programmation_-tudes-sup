class ExoE1 {
    public static void main(String[] args) {
        int n = Integer.parseInt(args[0]);
        int m = Integer.parseInt(args[1]);
        int result;
        if (n == 0)
            result = m + 1;
        else if (n == 1)
            result = m - 1;
        else
            result = m;
            System.out.println(result);
    }
}

class ExoE2 {
    public static void main(String[] args) {
        int n = Integer.parseInt(args[0]);
        int m = Integer.parseInt(args[1]);
        int result;
        switch(n) {
            case 0 : 
                result = m + 1;
                break;
            case 1 :
                result = m - 1;
                break;
            default : 
                result = m;
        }
        System.out.println(result);
    }
}

class ExoE3 {
    public static void main(String[] args) {
        int n = 11; 
        do {
            n -= 3;
            System.out.println("il en reste "+n);
        } while(n >= 2);
    }
}

class ExoE4 {
    public static void main(String[] args) {
        int prix = 11;
        int n = 0;
        while (n<=prix) {
            System.out.println("il faut encore payer "+(prix-n));
            n += 3;
        }
        System.out.println("c’est bon");
    }
}

class ExoE5 {
    public static void main(String[] args) {
        int n = 5;
        for(int i=0; i<n; i++) {
            for (int j=0; j<n; j++)
                System.out.print(j + " ");
            System.out.println();
        }
    }
}

class ExoE6 {
    public static void main(String[] args) {
        int n = 5;
        for (int i=0; i<n; i++) {
            for (int j=0; j<=i; j++)
            System.out.print(j + " ");
        System.out.println();
        }
    }
}

class ExoE7 {
    public static void main(String[] args) {
        double x = Math.random();
        System.out.println("x : " + x);
        System.out.println("10 * x : " + 10 * x);
        int n = (int) Math.round(10 * x);
        System.out.println("n : " + n);
    }
}

