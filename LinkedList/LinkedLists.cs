public class LinkedLists{
    Node head;

    public void append(int value){
        if(head == null){
            head = new Node(value);
            return;
        }
        Node current = head;
        while(current.next != null){
            current = current.next;
        }
        current.next = new Node(value);
    }

    public void preappend(int value){
        var newHead = new Node(value);
        newHead.next = head;
        head = newHead;
    }

    public bool deleteWithValue(int value){
        if(head == null) return false;
        if(head.value == value){
            head = head.next;
            return true;
        }

        Node current = head;
        while(current.next != null){
            if(current.next.value == value){
                current.next = current.next.next;
                return true;
            }
            current = current.next;
        }
        return false;
    }

    public void print(){     
        var current = head;
        while(current != null){
            System.Console.WriteLine(" - " + current.value);
            current = current.next;
        }
    }
}