import java.util.Scanner;

public class MovieRatings {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int moviesCount = Integer.parseInt(myObj.nextLine());
        String movieName;
        double rating;
        String maxMovie = "";
        double maxRating = 1.00;
        String minMovie = "";
        double minRating = 10.00;
        double averageRating = 0;
        int counter = 0;

        for (int i = 0; i < moviesCount; i++) {
            movieName = myObj.nextLine();
            rating = Double.parseDouble(myObj.nextLine());
            if (rating > maxRating) {
                maxMovie = movieName;
                maxRating = rating;
            }
            if (rating < minRating) {
                minMovie = movieName;
                minRating = rating;
            }
            averageRating += rating;
            counter++;
        }
        System.out.printf("%s is with highest rating: %.1f%n", maxMovie, maxRating);
        System.out.printf("%s is with lowest rating: %.1f%n", minMovie, minRating);
        System.out.printf("Average rating: %.1f", averageRating/counter);
    }
}
