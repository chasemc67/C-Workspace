namespace helloWorld
{
    // when you use generics, needs to be in class name
    // and then type is referenced as just t
    public class Node<T>
    {
        // properties are like normal fields, except they have a code block after them
        // difference is that properties are like fields, with the getter/setter rolled in.
        // you can define the get/set, or just use this shorthand
        public T leftHand{get; set;}
        public T rightHand{get;}
        
        public Node(T lh, T rh) {
            this.leftHand = lh;
            this.rightHand = rh;    
        }
    }
}