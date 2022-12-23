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
        public static float damage = 25f;
        public static float speed = 200f;
    }

    public class FieldStats : MonoBehaviour {
        public static float damage = 3f;
        public static float size = 3f;
        public static float coolDown = 0.5f;
    }

    public class WhipStats : MonoBehaviour {
        public static float damage = 25f;
        public static float length = 0.7f;
        public static float speed = 4f;
    }

    public class WaveStats : MonoBehaviour {
        public static float damage = 50f;
        public static float cooldown = 30f;
        public static float speed = 0.3f;
    }

    public class TrailStats : MonoBehaviour {
        public static float damage = 1f;
        public static float size = 1f;
        public static float coolDown = 2f;
    }
}

