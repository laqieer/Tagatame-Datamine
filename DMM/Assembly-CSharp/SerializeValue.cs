// Decompiled with JetBrains decompiler
// Type: SerializeValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000153")]
[Serializable]
public class SerializeValue
{
  [Token(Token = "0x4000661")]
  public const int GROUP_NONE = 0;
  [Token(Token = "0x4000662")]
  [FieldOffset(Offset = "0x0")]
  public static System.Type TYPE_GLOBAL;
  [Token(Token = "0x4000663")]
  [FieldOffset(Offset = "0x8")]
  [SerializeField]
  private int m_Group;
  [Token(Token = "0x4000664")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private SerializeValue.Type m_Type;
  [Token(Token = "0x4000665")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private string m_Key;
  [Token(Token = "0x4000666")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private GameObject m_Obj;
  [Token(Token = "0x4000667")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private ScriptableObject m_ScriptableObj;
  [Token(Token = "0x4000668")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private string m_Serialize;
  [Token(Token = "0x4000669")]
  [FieldOffset(Offset = "0x20")]
  private object m_Work;

  [Token(Token = "0x17000128")]
  public int group
  {
    [Token(Token = "0x6000826"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x17000129")]
  public SerializeValue.Type type
  {
    [Token(Token = "0x6000827"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return new SerializeValue.Type();
    }
  }

  [Token(Token = "0x1700012A")]
  public string key
  {
    [Token(Token = "0x6000828"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
    {
    }
    [Token(Token = "0x6000829"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x600082A")]
  [Address(RVA = "0xE5B070", Offset = "0xE59E70", VA = "0x10E5B070", Slot = "3")]
  public override string ToString() => (string) null;

  [Token(Token = "0x600082B")]
  [Address(RVA = "0xE5C3C0", Offset = "0xE5B1C0", VA = "0x10E5C3C0")]
  public SerializeValue()
  {
  }

  [Token(Token = "0x600082C")]
  [Address(RVA = "0xE5CBF0", Offset = "0xE5B9F0", VA = "0x10E5CBF0")]
  public SerializeValue(SerializeValue v)
  {
  }

  [Token(Token = "0x600082D")]
  [Address(RVA = "0xE5C860", Offset = "0xE5B660", VA = "0x10E5C860")]
  public SerializeValue(SerializeValue.Type type, string key, string serialize)
  {
  }

  [Token(Token = "0x600082E")]
  [Address(RVA = "0xE5CF60", Offset = "0xE5BD60", VA = "0x10E5CF60")]
  public SerializeValue(SerializeValue.Type type, string key)
  {
  }

  [Token(Token = "0x600082F")]
  [Address(RVA = "0xE5C8F0", Offset = "0xE5B6F0", VA = "0x10E5C8F0")]
  public SerializeValue(string key, bool value)
  {
  }

  [Token(Token = "0x6000830")]
  [Address(RVA = "0xE5C840", Offset = "0xE5B640", VA = "0x10E5C840")]
  public SerializeValue(bool value)
  {
  }

  [Token(Token = "0x6000831")]
  [Address(RVA = "0xE5C7D0", Offset = "0xE5B5D0", VA = "0x10E5C7D0")]
  public SerializeValue(string key, int value)
  {
  }

  [Token(Token = "0x6000832")]
  [Address(RVA = "0xE5C8D0", Offset = "0xE5B6D0", VA = "0x10E5C8D0")]
  public SerializeValue(int value)
  {
  }

  [Token(Token = "0x6000833")]
  [Address(RVA = "0xE5CA70", Offset = "0xE5B870", VA = "0x10E5CA70")]
  public SerializeValue(string key, float value)
  {
  }

  [Token(Token = "0x6000834")]
  [Address(RVA = "0xE5C760", Offset = "0xE5B560", VA = "0x10E5C760")]
  public SerializeValue(string key, long value)
  {
  }

  [Token(Token = "0x6000835")]
  [Address(RVA = "0xE5CDB0", Offset = "0xE5BBB0", VA = "0x10E5CDB0")]
  public SerializeValue(float value)
  {
  }

  [Token(Token = "0x6000836")]
  [Address(RVA = "0xE5C5A0", Offset = "0xE5B3A0", VA = "0x10E5C5A0")]
  public SerializeValue(string key, string value)
  {
  }

  [Token(Token = "0x6000837")]
  [Address(RVA = "0xE5CE60", Offset = "0xE5BC60", VA = "0x10E5CE60")]
  public SerializeValue(string value)
  {
  }

  [Token(Token = "0x6000838")]
  [Address(RVA = "0xE5CE80", Offset = "0xE5BC80", VA = "0x10E5CE80")]
  public SerializeValue(string key, Vector2 value)
  {
  }

  [Token(Token = "0x6000839")]
  [Address(RVA = "0xE5D180", Offset = "0xE5BF80", VA = "0x10E5D180")]
  public SerializeValue(Vector2 value)
  {
  }

  [Token(Token = "0x600083A")]
  [Address(RVA = "0xE5CD00", Offset = "0xE5BB00", VA = "0x10E5CD00")]
  public SerializeValue(string key, Vector3 value)
  {
  }

  [Token(Token = "0x600083B")]
  [Address(RVA = "0xE5CD80", Offset = "0xE5BB80", VA = "0x10E5CD80")]
  public SerializeValue(Vector3 value)
  {
  }

  [Token(Token = "0x600083C")]
  [Address(RVA = "0xE5C960", Offset = "0xE5B760", VA = "0x10E5C960")]
  public SerializeValue(string key, Vector4 value)
  {
  }

  [Token(Token = "0x600083D")]
  [Address(RVA = "0xE5C4D0", Offset = "0xE5B2D0", VA = "0x10E5C4D0")]
  public SerializeValue(Vector4 value)
  {
  }

  [Token(Token = "0x600083E")]
  [Address(RVA = "0xE5CEF0", Offset = "0xE5BCF0", VA = "0x10E5CEF0")]
  public SerializeValue(string key, GameObject obj)
  {
  }

  [Token(Token = "0x600083F")]
  [Address(RVA = "0xE5C580", Offset = "0xE5B380", VA = "0x10E5C580")]
  public SerializeValue(GameObject value)
  {
  }

  [Token(Token = "0x6000840")]
  [Address(RVA = "0xE5C6D0", Offset = "0xE5B4D0", VA = "0x10E5C6D0")]
  public SerializeValue(string key, Text obj)
  {
  }

  [Token(Token = "0x6000841")]
  [Address(RVA = "0xE5CAF0", Offset = "0xE5B8F0", VA = "0x10E5CAF0")]
  public SerializeValue(Text value)
  {
  }

  [Token(Token = "0x6000842")]
  [Address(RVA = "0xE5C640", Offset = "0xE5B440", VA = "0x10E5C640")]
  public SerializeValue(string key, Image obj)
  {
  }

  [Token(Token = "0x6000843")]
  [Address(RVA = "0xE5CDD0", Offset = "0xE5BBD0", VA = "0x10E5CDD0")]
  public SerializeValue(Image value)
  {
  }

  [Token(Token = "0x6000844")]
  [Address(RVA = "0xE5C9E0", Offset = "0xE5B7E0", VA = "0x10E5C9E0")]
  public SerializeValue(string key, Button obj)
  {
  }

  [Token(Token = "0x6000845")]
  [Address(RVA = "0xE5CC70", Offset = "0xE5BA70", VA = "0x10E5CC70")]
  public SerializeValue(Button value)
  {
  }

  [Token(Token = "0x6000846")]
  [Address(RVA = "0xE5C440", Offset = "0xE5B240", VA = "0x10E5C440")]
  public SerializeValue(string key, Toggle obj)
  {
  }

  [Token(Token = "0x6000847")]
  [Address(RVA = "0xE5C4F0", Offset = "0xE5B2F0", VA = "0x10E5C4F0")]
  public SerializeValue(Toggle value)
  {
  }

  [Token(Token = "0x6000848")]
  [Address(RVA = "0xE5CB80", Offset = "0xE5B980", VA = "0x10E5CB80")]
  public SerializeValue(string key, ScriptableObject obj)
  {
  }

  [Token(Token = "0x6000849")]
  [Address(RVA = "0xE5D110", Offset = "0xE5BF10", VA = "0x10E5D110")]
  public SerializeValue(ScriptableObject value)
  {
  }

  [Token(Token = "0x600084A")]
  [Address(RVA = "0xE59B60", Offset = "0xE58960", VA = "0x10E59B60")]
  public void Clear()
  {
  }

  [Token(Token = "0x600084B")]
  [Address(RVA = "0xE5A920", Offset = "0xE59720", VA = "0x10E5A920")]
  public void Reset()
  {
  }

  [Token(Token = "0x600084C")]
  [Address(RVA = "0xE5C0F0", Offset = "0xE5AEF0", VA = "0x10E5C0F0")]
  public void Write(SerializeValue src)
  {
  }

  [Token(Token = "0x600084D")]
  [Address(RVA = "0xE5BA90", Offset = "0xE5A890", VA = "0x10E5BA90")]
  public void Write(SerializeValue.PropertyType propType, SerializeValue src)
  {
  }

  [Token(Token = "0x600084E")]
  [Address(RVA = "0xE5A510", Offset = "0xE59310", VA = "0x10E5A510")]
  public string GetPropertyName(SerializeValue.PropertyType propType) => (string) null;

  [Token(Token = "0x600084F")]
  [Address(RVA = "0xE59CD0", Offset = "0xE58AD0", VA = "0x10E59CD0")]
  public bool Equal(SerializeValue.PropertyType propType, SerializeValue src) => new bool();

  [Token(Token = "0x6000850")]
  [Address(RVA = "0xE5A820", Offset = "0xE59620", VA = "0x10E5A820")]
  public bool Greater(SerializeValue.PropertyType propType, SerializeValue src) => new bool();

  [Token(Token = "0x6000851")]
  [Address(RVA = "0xE59BD0", Offset = "0xE589D0", VA = "0x10E59BD0")]
  public bool EqualGreater(SerializeValue.PropertyType propType, SerializeValue src) => new bool();

  [Token(Token = "0x6000852")]
  [Address(RVA = "0xE5A8A0", Offset = "0xE596A0", VA = "0x10E5A8A0")]
  public bool Less(SerializeValue.PropertyType propType, SerializeValue src) => new bool();

  [Token(Token = "0x6000853")]
  [Address(RVA = "0xE59C50", Offset = "0xE58A50", VA = "0x10E59C50")]
  public bool EqualLess(SerializeValue.PropertyType propType, SerializeValue src) => new bool();

  [Token(Token = "0x6000854")]
  [Address(RVA = "0xE5AC50", Offset = "0xE59A50", VA = "0x10E5AC50")]
  private void SetBool(bool value)
  {
  }

  [Token(Token = "0x6000855")]
  [Address(RVA = "0xE5A2A0", Offset = "0xE590A0", VA = "0x10E5A2A0")]
  private bool GetBool() => new bool();

  [Token(Token = "0x1700012B")]
  public bool v_bool
  {
    [Token(Token = "0x6000856"), Address(RVA = "0xE60100", Offset = "0xE5EF00", VA = "0x10E60100")] set
    {
    }
    [Token(Token = "0x6000857"), Address(RVA = "0xE5E5D0", Offset = "0xE5D3D0", VA = "0x10E5E5D0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000858")]
  [Address(RVA = "0xE5AD60", Offset = "0xE59B60", VA = "0x10E5AD60")]
  private void SetInt(int value)
  {
  }

  [Token(Token = "0x6000859")]
  [Address(RVA = "0xE5A400", Offset = "0xE59200", VA = "0x10E5A400")]
  private int GetInt() => new int();

  [Token(Token = "0x1700012C")]
  public int v_int
  {
    [Token(Token = "0x600085A"), Address(RVA = "0xE60360", Offset = "0xE5F160", VA = "0x10E60360")] set
    {
    }
    [Token(Token = "0x600085B"), Address(RVA = "0xE5EC30", Offset = "0xE5DA30", VA = "0x10E5EC30")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x600085C")]
  [Address(RVA = "0xE5ADE0", Offset = "0xE59BE0", VA = "0x10E5ADE0")]
  private void SetLong(long value)
  {
  }

  [Token(Token = "0x600085D")]
  [Address(RVA = "0xE5A480", Offset = "0xE59280", VA = "0x10E5A480")]
  private long GetLong() => new long();

  [Token(Token = "0x1700012D")]
  public long v_long
  {
    [Token(Token = "0x600085E"), Address(RVA = "0xE604B0", Offset = "0xE5F2B0", VA = "0x10E604B0")] set
    {
    }
    [Token(Token = "0x600085F"), Address(RVA = "0xE5EF90", Offset = "0xE5DD90", VA = "0x10E5EF90")] get
    {
      return new long();
    }
  }

  [Token(Token = "0x6000860")]
  [Address(RVA = "0xE5ACE0", Offset = "0xE59AE0", VA = "0x10E5ACE0")]
  private void SetFloat(float value)
  {
  }

  [Token(Token = "0x6000861")]
  [Address(RVA = "0xE5A340", Offset = "0xE59140", VA = "0x10E5A340")]
  private float GetFloat() => new float();

  [Token(Token = "0x1700012E")]
  public float v_float
  {
    [Token(Token = "0x6000862"), Address(RVA = "0xE601F0", Offset = "0xE5EFF0", VA = "0x10E601F0")] set
    {
    }
    [Token(Token = "0x6000863"), Address(RVA = "0xE5E8C0", Offset = "0xE5D6C0", VA = "0x10E5E8C0")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x6000864")]
  [Address(RVA = "0xE5AE70", Offset = "0xE59C70", VA = "0x10E5AE70")]
  private void SetString(string value)
  {
  }

  [Token(Token = "0x6000865")]
  [Address(RVA = "0xE5A5B0", Offset = "0xE593B0", VA = "0x10E5A5B0")]
  private string GetString() => (string) null;

  [Token(Token = "0x1700012F")]
  public string v_string
  {
    [Token(Token = "0x6000866"), Address(RVA = "0xE60640", Offset = "0xE5F440", VA = "0x10E60640")] set
    {
    }
    [Token(Token = "0x6000867"), Address(RVA = "0xE5F430", Offset = "0xE5E230", VA = "0x10E5F430")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x6000868")]
  [Address(RVA = "0xE5B780", Offset = "0xE5A580", VA = "0x10E5B780")]
  public static Vector2 Vector2_Parse(string value) => new Vector2();

  [Token(Token = "0x6000869")]
  [Address(RVA = "0xE5AEC0", Offset = "0xE59CC0", VA = "0x10E5AEC0")]
  private void SetVector2(Vector2 value)
  {
  }

  [Token(Token = "0x600086A")]
  [Address(RVA = "0xE5A620", Offset = "0xE59420", VA = "0x10E5A620")]
  private Vector2 GetVector2() => new Vector2();

  [Token(Token = "0x17000130")]
  public Vector2 v_Vector2
  {
    [Token(Token = "0x600086B"), Address(RVA = "0xE5FF70", Offset = "0xE5ED70", VA = "0x10E5FF70")] set
    {
    }
    [Token(Token = "0x600086C"), Address(RVA = "0xE5E070", Offset = "0xE5CE70", VA = "0x10E5E070")] get
    {
      return new Vector2();
    }
  }

  [Token(Token = "0x600086D")]
  [Address(RVA = "0xE5B870", Offset = "0xE5A670", VA = "0x10E5B870")]
  public static Vector3 Vector3_Parse(string value) => new Vector3();

  [Token(Token = "0x600086E")]
  [Address(RVA = "0xE5AF50", Offset = "0xE59D50", VA = "0x10E5AF50")]
  private void SetVector3(Vector3 value)
  {
  }

  [Token(Token = "0x600086F")]
  [Address(RVA = "0xE5A6C0", Offset = "0xE594C0", VA = "0x10E5A6C0")]
  private Vector3 GetVector3() => new Vector3();

  [Token(Token = "0x17000131")]
  public Vector3 v_Vector3
  {
    [Token(Token = "0x6000870"), Address(RVA = "0xE5FFF0", Offset = "0xE5EDF0", VA = "0x10E5FFF0")] set
    {
    }
    [Token(Token = "0x6000871"), Address(RVA = "0xE5E250", Offset = "0xE5D050", VA = "0x10E5E250")] get
    {
      return new Vector3();
    }
  }

  [Token(Token = "0x6000872")]
  [Address(RVA = "0xE5B980", Offset = "0xE5A780", VA = "0x10E5B980")]
  public static Vector4 Vector4_Parse(string value) => new Vector4();

  [Token(Token = "0x6000873")]
  [Address(RVA = "0xE5AFF0", Offset = "0xE59DF0", VA = "0x10E5AFF0")]
  private void SetVector4(Vector4 value)
  {
  }

  [Token(Token = "0x6000874")]
  [Address(RVA = "0xE5A770", Offset = "0xE59570", VA = "0x10E5A770")]
  private Vector4 GetVector4() => new Vector4();

  [Token(Token = "0x17000132")]
  public Vector4 v_Vector4
  {
    [Token(Token = "0x6000875"), Address(RVA = "0xE60080", Offset = "0xE5EE80", VA = "0x10E60080")] set
    {
    }
    [Token(Token = "0x6000876"), Address(RVA = "0xE5E420", Offset = "0xE5D220", VA = "0x10E5E420")] get
    {
      return new Vector4();
    }
  }

  [Token(Token = "0x17000133")]
  public GameObject v_GameObject
  {
    [Token(Token = "0x6000877"), Address(RVA = "0xE5F8B0", Offset = "0xE5E6B0", VA = "0x10E5F8B0")] set
    {
    }
    [Token(Token = "0x6000878"), Address(RVA = "0xE5D2B0", Offset = "0xE5C0B0", VA = "0x10E5D2B0")] get
    {
      return (GameObject) null;
    }
  }

  [Token(Token = "0x17000134")]
  public Text v_UILabel
  {
    [Token(Token = "0x6000879"), Address(RVA = "0xE5FC60", Offset = "0xE5EA60", VA = "0x10E5FC60")] set
    {
    }
    [Token(Token = "0x600087A"), Address(RVA = "0xE5DB70", Offset = "0xE5C970", VA = "0x10E5DB70")] get
    {
      return (Text) null;
    }
  }

  [Token(Token = "0x17000135")]
  public Image v_UIImage
  {
    [Token(Token = "0x600087B"), Address(RVA = "0xE5FB40", Offset = "0xE5E940", VA = "0x10E5FB40")] set
    {
    }
    [Token(Token = "0x600087C"), Address(RVA = "0xE5D9A0", Offset = "0xE5C7A0", VA = "0x10E5D9A0")] get
    {
      return (Image) null;
    }
  }

  [Token(Token = "0x17000136")]
  public Button v_UIButton
  {
    [Token(Token = "0x600087D"), Address(RVA = "0xE5FA90", Offset = "0xE5E890", VA = "0x10E5FA90")] set
    {
    }
    [Token(Token = "0x600087E"), Address(RVA = "0xE5D850", Offset = "0xE5C650", VA = "0x10E5D850")] get
    {
      return (Button) null;
    }
  }

  [Token(Token = "0x17000137")]
  public Toggle v_UIToggle
  {
    [Token(Token = "0x600087F"), Address(RVA = "0xE5FEC0", Offset = "0xE5ECC0", VA = "0x10E5FEC0")] set
    {
    }
    [Token(Token = "0x6000880"), Address(RVA = "0xE5DF20", Offset = "0xE5CD20", VA = "0x10E5DF20")] get
    {
      return (Toggle) null;
    }
  }

  [Token(Token = "0x17000138")]
  public ScriptableObject v_ScriptableObject
  {
    [Token(Token = "0x6000881"), Address(RVA = "0xE5FA50", Offset = "0xE5E850", VA = "0x10E5FA50")] set
    {
    }
    [Token(Token = "0x6000882"), Address(RVA = "0xE5D770", Offset = "0xE5C570", VA = "0x10E5D770")] get
    {
      return (ScriptableObject) null;
    }
  }

  [Token(Token = "0x6000883")]
  [Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")]
  private void SetGlobal(string value)
  {
  }

  [Token(Token = "0x6000884")]
  [Address(RVA = "0xE5A3C0", Offset = "0xE591C0", VA = "0x10E5A3C0")]
  private string GetGlobal() => (string) null;

  [Token(Token = "0x17000139")]
  public object v_Global
  {
    [Token(Token = "0x6000885"), Address(RVA = "0xE5F910", Offset = "0xE5E710", VA = "0x10E5F910")] set
    {
    }
    [Token(Token = "0x6000886"), Address(RVA = "0xE5D3A0", Offset = "0xE5C1A0", VA = "0x10E5D3A0")] get
    {
      return (object) null;
    }
  }

  [Token(Token = "0x1700013A")]
  public object v_Object
  {
    [Token(Token = "0x6000887"), Address(RVA = "0xE5FA30", Offset = "0xE5E830", VA = "0x10E5FA30")] set
    {
    }
    [Token(Token = "0x6000888"), Address(RVA = "0xE5D690", Offset = "0xE5C490", VA = "0x10E5D690")] get
    {
      return (object) null;
    }
  }

  [Token(Token = "0x1700013B")]
  public MonoBehaviour v_MonoBehaviour
  {
    [Token(Token = "0x6000889"), Address(RVA = "0xE5D460", Offset = "0xE5C260", VA = "0x10E5D460")] get
    {
      return (MonoBehaviour) null;
    }
  }

  [Token(Token = "0x1700013C")]
  public Component v_Component
  {
    [Token(Token = "0x600088A"), Address(RVA = "0xE5D220", Offset = "0xE5C020", VA = "0x10E5D220")] get
    {
      return (Component) null;
    }
  }

  [Token(Token = "0x1700013D")]
  public bool v_Active
  {
    [Token(Token = "0x600088B"), Address(RVA = "0xE5F7D0", Offset = "0xE5E5D0", VA = "0x10E5F7D0")] set
    {
    }
    [Token(Token = "0x600088C"), Address(RVA = "0xE5D1A0", Offset = "0xE5BFA0", VA = "0x10E5D1A0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700013E")]
  public bool v_Enable
  {
    [Token(Token = "0x600088D"), Address(RVA = "0xE5F840", Offset = "0xE5E640", VA = "0x10E5F840")] set
    {
    }
    [Token(Token = "0x600088E"), Address(RVA = "0xE5D230", Offset = "0xE5C030", VA = "0x10E5D230")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700013F")]
  public Selectable v_UISelectable
  {
    [Token(Token = "0x600088F"), Address(RVA = "0xE5FD70", Offset = "0xE5EB70", VA = "0x10E5FD70")] set
    {
    }
    [Token(Token = "0x6000890"), Address(RVA = "0xE5DD30", Offset = "0xE5CB30", VA = "0x10E5DD30")] get
    {
      return (Selectable) null;
    }
  }

  [Token(Token = "0x17000140")]
  public string v_UIText
  {
    [Token(Token = "0x6000891"), Address(RVA = "0xE5FE40", Offset = "0xE5EC40", VA = "0x10E5FE40")] set
    {
    }
    [Token(Token = "0x6000892"), Address(RVA = "0xE5DE90", Offset = "0xE5CC90", VA = "0x10E5DE90")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000141")]
  public bool v_UIInteractable
  {
    [Token(Token = "0x6000893"), Address(RVA = "0xE5FBF0", Offset = "0xE5E9F0", VA = "0x10E5FBF0")] set
    {
    }
    [Token(Token = "0x6000894"), Address(RVA = "0xE5DAE0", Offset = "0xE5C8E0", VA = "0x10E5DAE0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x17000142")]
  public bool v_UIOn
  {
    [Token(Token = "0x6000895"), Address(RVA = "0xE5FD00", Offset = "0xE5EB00", VA = "0x10E5FD00")] set
    {
    }
    [Token(Token = "0x6000896"), Address(RVA = "0xE5DCB0", Offset = "0xE5CAB0", VA = "0x10E5DCB0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000897")]
  public T GetEnum<T>() => (T) null;

  [Token(Token = "0x6000898")]
  [Address(RVA = "0xE5C340", Offset = "0xE5B140", VA = "0x10E5C340")]
  static SerializeValue()
  {
  }

  [Token(Token = "0x2000154")]
  public enum Type
  {
    [Token(Token = "0x400066B")] NONE,
    [Token(Token = "0x400066C")] Bool,
    [Token(Token = "0x400066D")] Int,
    [Token(Token = "0x400066E")] Float,
    [Token(Token = "0x400066F")] String,
    [Token(Token = "0x4000670")] Vector2,
    [Token(Token = "0x4000671")] Vector3,
    [Token(Token = "0x4000672")] Vector4,
    [Token(Token = "0x4000673")] GameObject,
    [Token(Token = "0x4000674")] UILabel,
    [Token(Token = "0x4000675")] UIButton,
    [Token(Token = "0x4000676")] UIToggle,
    [Token(Token = "0x4000677")] ScriptableObject,
    [Token(Token = "0x4000678")] Global,
    [Token(Token = "0x4000679")] UIImage,
    [Token(Token = "0x400067A")] Object,
    [Token(Token = "0x400067B")] Long,
  }

  [Token(Token = "0x2000155")]
  public enum PropertyType
  {
    [Token(Token = "0x400067D")] Bool,
    [Token(Token = "0x400067E")] Int,
    [Token(Token = "0x400067F")] Float,
    [Token(Token = "0x4000680")] String,
    [Token(Token = "0x4000681")] Vector2,
    [Token(Token = "0x4000682")] Vector3,
    [Token(Token = "0x4000683")] Vector4,
    [Token(Token = "0x4000684")] GameObject,
    [Token(Token = "0x4000685")] UILabel,
    [Token(Token = "0x4000686")] UIButton,
    [Token(Token = "0x4000687")] UIToggle,
    [Token(Token = "0x4000688")] ScriptableObject,
    [Token(Token = "0x4000689")] Global,
    [Token(Token = "0x400068A")] Active,
    [Token(Token = "0x400068B")] Enable,
    [Token(Token = "0x400068C")] UISelectable,
    [Token(Token = "0x400068D")] UIText,
    [Token(Token = "0x400068E")] UIInteractabel,
    [Token(Token = "0x400068F")] UIOn,
    [Token(Token = "0x4000690")] UIImage,
    [Token(Token = "0x4000691")] Object,
    [Token(Token = "0x4000692")] Long,
  }
}
