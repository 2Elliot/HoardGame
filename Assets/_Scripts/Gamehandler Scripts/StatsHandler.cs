using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Stats {

    public class PlayerStats : MonoBehaviour {
	    public static float speed = 15f;
        public static float range = 2f;
	    public static int xp = 0;
        public static int level = 0;
        public static int maxHp = 100;
        public static int currentHp = 100;
    }

    public class XpStats : MonoBehaviour {
        public static float size = 3f;
        public static int maxXp = 25;
    }

    public class SawStats : MonoBehaviour {
        public static float area = 3f;
        public static int damage = 25;
        public static float speed = 200f;
    }

    public class FieldStats : MonoBehaviour {
        public static int damage = 5;
        public static float size = 3f;
        public static float coolDown = 0.05f;
    }

    public class WhipStats : MonoBehaviour {
        public static int damage = 25;
        public static float length = 0.5f;
        public static float speed = 2f;
    }

    public class WaveStats : MonoBehaviour {
        public static int damage = 50;
        public static float cooldown = 30f;
        public static float speed = 0.3f;
    }

    public class TrailStats : MonoBehaviour {
        public static int damage = 1;
        public static float size = 1.5f;
        public static float coolDown = 2f;
        public static float length = 5f;
    }

    public class ShootStats : MonoBehaviour {
        public static int damage = 10;
        public static int number = 3;
        public static float spread = 15f;
        public static float distance = 2f;
        public static float speed = 20f;
        public static float coolDown = 2f;
    }
}

