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
public class SinglyLinkedList {
    
    // global variables pointin to the first
    // and last values in the list
    private Employee first;
    private Employee last;
    
    /**
     * constructor to initiliaze global variables
     */
    SinglyLinkedList(){
        this.first = null;
        this.last = null;
    }
    
    /**
     * method to return the element of a SinglyLinkedList at index
     * @param index
     * @return 
     */
    public Employee get(int index){
        if (last == null){ return null; }
        else{
            Employee iter = first;
            for (int i = 0; i < index; i++){ iter = iter.getNext(); }
            return iter;
        }
    }
    
    /**
     * method to add an element to the end of a SinglyLinkedList
     * @param temp 
     */
    public void addLast(Employee temp){
        // check is list is empty, make tempt the first element
        if (last == null){
            this.first = temp;
            this.last = temp;
        }
        // otherwise, add temp to the end
        else{
            last.setNext(temp);
            last = temp;
        }
    }
    
}
