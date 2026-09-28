public class DynamicArray {
    int Capacity;
    object[] dynArr;
    int count;
    public DynamicArray(int capacity) {
        Capacity = capacity;
        dynArr = new object[Capacity];
        count = 0;
    }

    public int Get(int i) {
        return (int)dynArr[i];
    }

    public void Set(int i, int n) {
        dynArr[i] = n;
    }

    public void PushBack(int n) {
         if(GetSize() >= Capacity){
            Resize();
        }
        dynArr[GetSize()] = n;
        count++;
    }

    public int PopBack() {
           if(GetSize() != 0){
            int temp1 = (int)dynArr[GetSize() - 1];
            dynArr[GetSize() - 1] = null;
            count--;
            return temp1; 
        }
        return 0;
    }

    private void Resize() {
        object[] temp = dynArr;
        Capacity *= 2;
        dynArr = new object[Capacity];
        for(int i = 0; i < temp.Length; i++){
            dynArr[i] = temp[i];
        }
    }

    public int GetSize() {
        return count;
    }

    public int GetCapacity() {
        return Capacity;
    }
}
