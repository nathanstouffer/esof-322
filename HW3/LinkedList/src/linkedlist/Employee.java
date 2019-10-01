/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package linkedlist;

/**
 *
 * @author natha
 */
public class Employee {
    
    // global varaibles with information about the Employee
    private String name;
    private int social_security;
    private int salary;
    // next element in linked list
    private Employee next = null;
    
    /**
     * constructor to initialize global variables
     * @param name
     * @param social_security
     * @param salary 
     */
    Employee(String name, int social_security, int salary){
        this.name = name;
        this.social_security = social_security;
        this.salary = salary;
    }
    
    /**
     * method to set the next element in the linked list
     * @param temp 
     */
    public void setNext(Employee temp){ this.next = temp; }
    
    /**
     * method to return the next element in the linked list
     * @return 
     */
    public Employee getNext(){ return this.next; }
    
    /**
     * method to return the information of the employee
     * @return 
     */
    @Override
    public String toString(){ 
        return "name: " + name + " social security: " + Integer.toString(social_security)
                + " salary: " + Integer.toString(salary) + "\n";
    }
}
