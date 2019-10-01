/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hw2javaproject;

import java.util.Scanner;

/**
 *
 * @author natha
 */
public class Client {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // create scanner for user input
        // Scanner scn = new Scanner(System.in);
        // db will perform database operations
        // default store strategy is relational
        DatabaseSoftware db = new DatabaseSoftware();
        // variable that will repeat loop if necessary
        boolean ask_input = true;
        
        String data = "A line of data";
        
        db.Store(data);
        
        db.setStoreStrategy(new NoSQL());
        db.Store(data);
        
        db.setStoreStrategy(new Graph());
        db.Store(data);
        db.Store(data);
        
        db.setStoreStrategy(new Relational());
        db.Store(data);
        
        /*
        while (ask_input){
            // display options
            System.out.println("Choose a database input tool.");
            System.out.println("1. Relational 2. NoSQL 3. Graph");
            
            // get user response
            int input = scn.nextInt();
            scn.nextLine();
            
            // variable store whether user input was valid
            boolean store_data = true;
            
            // sets the store strategy based on user choice
            switch (input){
                case 1:
                    db.setStoreStrategy(new Relational());
                    break;
                case 2:
                    db.setStoreStrategy(new NoSQL());
                    break;
                case 3:
                    db.setStoreStrategy(new Graph());
                    break;
                default:
                    System.out.println("Choose a valid option.");
                    store_data = false;
            }
            
            if (store_data){
                // store data in the database
                String data = "A line of data\n";
                db.Store(data);
            }
            
            // ask if user wants to continue
            System.out.println("Continue?");
            System.out.println("1. yes 2. no");
            
            // get user input
            input = scn.nextInt();
            scn.nextLine();
            
            if (input == 1){ System.out.println(); }
            if (input == 2){ ask_input = false; }
        }
        */
    }
    
}
