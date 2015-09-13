package app.com.example.android.sunshine;

import android.test.AndroidTestCase;

public class HelloWorldAndroidTests extends AndroidTestCase {  
    @Override
    protected void setUp() throws Exception {
        super.setUp();
    }

    @Override
    protected void tearDown() throws Exception {
        super.tearDown();
    }

    public void testAble_to_add_two_positive_numbers()  {
        int actual = 8;

        Calculator calc = new Calculator(2, 6);
        assertEquals(calc.Add(), actual);
    }

    public void testAble_to_add_two_negative_numbers()  {
        int actual = -8;

        Calculator calc = new Calculator(-2, -6);
        assertEquals(calc.Add(), actual);
    }

    public void testAble_to_divide_by_zero() {
        int actual = 0;

        Calculator calc = new Calculator(10, 0);
        assertEquals(calc.Divide(), actual);
    }

    class Calculator {
        private final int _x;
        private final int _y;

        public Calculator(int x, int y) {
            _x = x;
            _y = y;
        }

        public int Add() {
            return _x + _y;
        }

        public int Divide() {
            if (_y < 1) return 0;

            return _x / _y;
        }
    }
}