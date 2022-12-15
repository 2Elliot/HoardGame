using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stats {

    public class Player{
	    public static float speed = 5f;
        public static float range = 2f;
	    public static float xp = 0f;
    }

    public static class Xp {
        public static float area = 3f;
    }

    public static class Saw {
        public static float area = 3f;
        public static float damage = 25f;
        public static float speed = 200f;
    }

    public static class Field {
        public static float damage = 5f;
        public static float size = 3f;
        public static float coolDown = 1f;
    }

    public static class Whip {
        public static float damage = 25f;
        public static float length = 0.3f;
        public static float speed = 1.5f;
    }

    public static class Wave {
        public static float damage = 50f;
        public static float cooldown = 5f;
        public static float speed = 0.3f;
    }
}

