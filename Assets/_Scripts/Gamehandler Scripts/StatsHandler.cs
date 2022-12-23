using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Stats {

    public class PlayerStats : MonoBehaviour {
	    public static float speed = 15f;
        public static float range = 2f;
	    public static float xp = 0f;
    }

    public class XpStats : MonoBehaviour {
        public static float size = 3f;
    }

    public class SawStats : MonoBehaviour {
        public static float area = 3f;
        public static int damage = 25;
        public static float speed = 200f;
    }

    public class FieldStats : MonoBehaviour {
        public static int damage = 3;
        public static float size = 3f;
        public static float coolDown = 0.5f;
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
        public static float size = 1f;
        public static float coolDown = 2f;
    }
}

