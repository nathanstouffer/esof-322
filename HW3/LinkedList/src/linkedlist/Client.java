/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package linkedlist;

import java.util.Random;

/**
 *
 * @author natha
 */
public class Client {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // creating a an instance of SinglyLinkedList
        SinglyLinkedList list = new SinglyLinkedList();
        Random rand = new Random();
        // inserting values into the list
        for (int i = 0; i < 5; i++){
            list.addLast(new Employee("test", rand.nextInt(), rand.nextInt()));
        }
        // printing the contents of the list
        for (int i = 0; i < 5; i++){
            System.out.print(list.get(i));
        }
    }    
    
}
