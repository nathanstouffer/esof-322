/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hw2javaproject;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

/**
 * class that stores data using the Graph tool
 * (via that node store method)
 * 
 * class Relational implements the IDatabaseTool interface
 * @author natha
 */
public class Graph implements IDatabaseTool {
    
    /**
     * constructor to output dummy line to tell user
     * that they are now using the NoSQL tool
     */
    Graph(){
        System.out.println("\nYou are using the Graph database tool");
    }
    
    /**
     * method to store data using the node store method
     * @param data
     * @param file_name 
     */
    public void store(String data, String file_name){
        fileOutput(data, file_name);
        System.out.println("Stored data using node store method");
    }
    
    /**
     * method to write the data to an output file
     * @param data
     * @param file_name 
     */
    private void fileOutput(String data, String file_name){
        File file = new File(file_name);
        try{
            FileWriter fw = new FileWriter(file, true);
            fw.write(data);
            fw.close();
        }
        catch (IOException e){ System.err.println("IO error"); }
    }
    
}
