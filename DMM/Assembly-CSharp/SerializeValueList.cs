// Decompiled with JetBrains decompiler
// Type: SerializeValueList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000157")]
[Serializable]
public class SerializeValueList
{
  [Token(Token = "0x4000694")]
  [FieldOffset(Offset = "0x8")]
  [SerializeField]
  private List<SerializeValue> m_Fields;

  [Token(Token = "0x17000144")]
  public List<SerializeValue> list
  {
    [Token(Token = "0x600089C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
    {
      return (List<SerializeValue>) null;
    }
  }

  [Token(Token = "0x17000145")]
  public int Count
  {
    [Token(Token = "0x600089D"), Address(RVA = "0xE59B20", Offset = "0xE58920", VA = "0x10E59B20")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x600089E")]
  [Address(RVA = "0xE59640", Offset = "0xE58440", VA = "0x10E59640")]
  public SerializeValue[] ToArray() => (SerializeValue[]) null;

  [Token(Token = "0x600089F")]
  [Address(RVA = "0xE57790", Offset = "0xE56590", VA = "0x10E57790")]
  public List<string> GetKeys() => (List<string>) null;

  [Token(Token = "0x60008A0")]
  [Address(RVA = "0xE575A0", Offset = "0xE563A0", VA = "0x10E575A0")]
  public List<int> GetGroups() => (List<int>) null;

  [Token(Token = "0x60008A1")]
  [Address(RVA = "0xE59990", Offset = "0xE58790", VA = "0x10E59990")]
  public SerializeValueList()
  {
  }

  [Token(Token = "0x60008A2")]
  [Address(RVA = "0xE59910", Offset = "0xE58710", VA = "0x10E59910")]
  public SerializeValueList(SerializeValueList list)
  {
  }

  [Token(Token = "0x60008A3")]
  [Address(RVA = "0xE59AA0", Offset = "0xE588A0", VA = "0x10E59AA0")]
  public SerializeValueList(List<SerializeValue> array)
  {
  }

  [Token(Token = "0x60008A4")]
  [Address(RVA = "0xE59A00", Offset = "0xE58800", VA = "0x10E59A00")]
  public SerializeValueList(SerializeValue[] array)
  {
  }

  [Token(Token = "0x60008A5")]
  [Address(RVA = "0xE57FD0", Offset = "0xE56DD0", VA = "0x10E57FD0")]
  public void Initialize()
  {
  }

  [Token(Token = "0x60008A6")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void Release()
  {
  }

  [Token(Token = "0x60008A7")]
  [Address(RVA = "0xE565B0", Offset = "0xE553B0", VA = "0x10E565B0")]
  public void Clear()
  {
  }

  [Token(Token = "0x60008A8")]
  [Address(RVA = "0xE59780", Offset = "0xE58580", VA = "0x10E59780")]
  public void Write(SerializeValueList src)
  {
  }

  [Token(Token = "0x60008A9")]
  [Address(RVA = "0xE584D0", Offset = "0xE572D0", VA = "0x10E584D0")]
  public void RemoveFieldAt(int index)
  {
  }

  [Token(Token = "0x60008AA")]
  [Address(RVA = "0xE58520", Offset = "0xE57320", VA = "0x10E58520")]
  public void RemoveField(SerializeValue value)
  {
  }

  [Token(Token = "0x60008AB")]
  [Address(RVA = "0xE58570", Offset = "0xE57370", VA = "0x10E58570")]
  public void RemoveField(string key)
  {
  }

  [Token(Token = "0x60008AC")]
  [Address(RVA = "0xE58400", Offset = "0xE57200", VA = "0x10E58400")]
  public SerializeValue NewField(SerializeValue value) => (SerializeValue) null;

  [Token(Token = "0x60008AD")]
  [Address(RVA = "0xE58450", Offset = "0xE57250", VA = "0x10E58450")]
  public SerializeValue NewField(SerializeValue.Type type, string key) => (SerializeValue) null;

  [Token(Token = "0x60008AE")]
  [Address(RVA = "0xE56500", Offset = "0xE55300", VA = "0x10E56500")]
  public void Add(SerializeValueList list)
  {
  }

  [Token(Token = "0x60008AF")]
  [Address(RVA = "0xE56200", Offset = "0xE55000", VA = "0x10E56200")]
  public SerializeValue AddField(SerializeValue value) => (SerializeValue) null;

  [Token(Token = "0x60008B0")]
  [Address(RVA = "0xE55F50", Offset = "0xE54D50", VA = "0x10E55F50")]
  public SerializeValue AddField(SerializeValue.Type type, string key) => (SerializeValue) null;

  [Token(Token = "0x60008B1")]
  [Address(RVA = "0xE55B40", Offset = "0xE54940", VA = "0x10E55B40")]
  public SerializeValue AddField(SerializeValue.Type type, string key, GameObject obj)
  {
    return (SerializeValue) null;
  }

  [Token(Token = "0x60008B2")]
  [Address(RVA = "0xE55C60", Offset = "0xE54A60", VA = "0x10E55C60")]
  public SerializeValue AddField(string key, bool obj) => (SerializeValue) null;

  [Token(Token = "0x60008B3")]
  [Address(RVA = "0xE55E20", Offset = "0xE54C20", VA = "0x10E55E20")]
  public SerializeValue AddField(string key, int obj) => (SerializeValue) null;

  [Token(Token = "0x60008B4")]
  [Address(RVA = "0xE559D0", Offset = "0xE547D0", VA = "0x10E559D0")]
  public SerializeValue AddField(string key, long obj) => (SerializeValue) null;

  [Token(Token = "0x60008B5")]
  [Address(RVA = "0xE55EB0", Offset = "0xE54CB0", VA = "0x10E55EB0")]
  public SerializeValue AddField(string key, float obj) => (SerializeValue) null;

  [Token(Token = "0x60008B6")]
  [Address(RVA = "0xE56170", Offset = "0xE54F70", VA = "0x10E56170")]
  public SerializeValue AddField(string key, string obj) => (SerializeValue) null;

  [Token(Token = "0x60008B7")]
  [Address(RVA = "0xE560E0", Offset = "0xE54EE0", VA = "0x10E560E0")]
  public SerializeValue AddField(string key, Vector2 obj) => (SerializeValue) null;

  [Token(Token = "0x60008B8")]
  [Address(RVA = "0xE55D80", Offset = "0xE54B80", VA = "0x10E55D80")]
  public SerializeValue AddField(string key, Vector3 obj) => (SerializeValue) null;

  [Token(Token = "0x60008B9")]
  [Address(RVA = "0xE56040", Offset = "0xE54E40", VA = "0x10E56040")]
  public SerializeValue AddField(string key, Vector4 obj) => (SerializeValue) null;

  [Token(Token = "0x60008BA")]
  [Address(RVA = "0xE55AB0", Offset = "0xE548B0", VA = "0x10E55AB0")]
  public SerializeValue AddField(string key, GameObject obj) => (SerializeValue) null;

  [Token(Token = "0x60008BB")]
  [Address(RVA = "0xE55CF0", Offset = "0xE54AF0", VA = "0x10E55CF0")]
  public SerializeValue AddField(string key, Text obj) => (SerializeValue) null;

  [Token(Token = "0x60008BC")]
  [Address(RVA = "0xE55BD0", Offset = "0xE549D0", VA = "0x10E55BD0")]
  public SerializeValue AddField(string key, Button obj) => (SerializeValue) null;

  [Token(Token = "0x60008BD")]
  [Address(RVA = "0xE55FB0", Offset = "0xE54DB0", VA = "0x10E55FB0")]
  public SerializeValue AddField(string key, Toggle obj) => (SerializeValue) null;

  [Token(Token = "0x60008BE")]
  [Address(RVA = "0xE562F0", Offset = "0xE550F0", VA = "0x10E562F0")]
  public SerializeValue AddGlobal(string key, string fieldName, object obj)
  {
    return (SerializeValue) null;
  }

  [Token(Token = "0x60008BF")]
  [Address(RVA = "0xE563E0", Offset = "0xE551E0", VA = "0x10E563E0")]
  public SerializeValue AddObject(string key, object obj) => (SerializeValue) null;

  [Token(Token = "0x60008C0")]
  [Address(RVA = "0xE58C30", Offset = "0xE57A30", VA = "0x10E58C30")]
  public void SetField(SerializeValue value)
  {
  }

  [Token(Token = "0x60008C1")]
  [Address(RVA = "0xE59010", Offset = "0xE57E10", VA = "0x10E59010")]
  public void SetField(string key, bool value)
  {
  }

  [Token(Token = "0x60008C2")]
  [Address(RVA = "0xE58D40", Offset = "0xE57B40", VA = "0x10E58D40")]
  public void SetField(string key, int value)
  {
  }

  [Token(Token = "0x60008C3")]
  [Address(RVA = "0xE58B20", Offset = "0xE57920", VA = "0x10E58B20")]
  public void SetField(string key, long value)
  {
  }

  [Token(Token = "0x60008C4")]
  [Address(RVA = "0xE58DF0", Offset = "0xE57BF0", VA = "0x10E58DF0")]
  public void SetField(string key, float value)
  {
  }

  [Token(Token = "0x60008C5")]
  [Address(RVA = "0xE589C0", Offset = "0xE577C0", VA = "0x10E589C0")]
  public void SetField(string key, string value)
  {
  }

  [Token(Token = "0x60008C6")]
  [Address(RVA = "0xE58EB0", Offset = "0xE57CB0", VA = "0x10E58EB0")]
  public void SetField(string key, Vector2 value)
  {
  }

  [Token(Token = "0x60008C7")]
  [Address(RVA = "0xE59170", Offset = "0xE57F70", VA = "0x10E59170")]
  public void SetField(string key, Vector3 value)
  {
  }

  [Token(Token = "0x60008C8")]
  [Address(RVA = "0xE59250", Offset = "0xE58050", VA = "0x10E59250")]
  public void SetField(string key, Vector4 value)
  {
  }

  [Token(Token = "0x60008C9")]
  [Address(RVA = "0xE58F60", Offset = "0xE57D60", VA = "0x10E58F60")]
  public void SetField(string key, GameObject value)
  {
  }

  [Token(Token = "0x60008CA")]
  [Address(RVA = "0xE58A70", Offset = "0xE57870", VA = "0x10E58A70")]
  public void SetField(string key, Text value)
  {
  }

  [Token(Token = "0x60008CB")]
  [Address(RVA = "0xE590C0", Offset = "0xE57EC0", VA = "0x10E590C0")]
  public void SetField(string key, Button value)
  {
  }

  [Token(Token = "0x60008CC")]
  [Address(RVA = "0xE58910", Offset = "0xE57710", VA = "0x10E58910")]
  public void SetField(string key, Toggle value)
  {
  }

  [Token(Token = "0x60008CD")]
  [Address(RVA = "0xE59310", Offset = "0xE58110", VA = "0x10E59310")]
  public void SetGlobal(string key, string fieldName, object obj)
  {
  }

  [Token(Token = "0x60008CE")]
  [Address(RVA = "0xE594C0", Offset = "0xE582C0", VA = "0x10E594C0")]
  public void SetObject(string key, object obj)
  {
  }

  [Token(Token = "0x60008CF")]
  [Address(RVA = "0xE58650", Offset = "0xE57450", VA = "0x10E58650")]
  public void SetActive(int group, bool sw)
  {
  }

  [Token(Token = "0x60008D0")]
  [Address(RVA = "0xE58760", Offset = "0xE57560", VA = "0x10E58760")]
  public GameObject SetActive(string key, bool sw) => (GameObject) null;

  [Token(Token = "0x60008D1")]
  [Address(RVA = "0xE58800", Offset = "0xE57600", VA = "0x10E58800")]
  public GameObject SetActive(string key, bool sw, string label) => (GameObject) null;

  [Token(Token = "0x60008D2")]
  [Address(RVA = "0xE59610", Offset = "0xE58410", VA = "0x10E59610")]
  public void SetUIOn(string key, bool value)
  {
  }

  [Token(Token = "0x60008D3")]
  [Address(RVA = "0xE59430", Offset = "0xE58230", VA = "0x10E59430")]
  public Selectable SetInteractable(string key, bool value) => (Selectable) null;

  [Token(Token = "0x60008D4")]
  [Address(RVA = "0xE56BC0", Offset = "0xE559C0", VA = "0x10E56BC0")]
  public SerializeValue GetField(string key) => (SerializeValue) null;

  [Token(Token = "0x60008D5")]
  [Address(RVA = "0xE59680", Offset = "0xE58480", VA = "0x10E59680")]
  public bool TryGetField(string key, out SerializeValue field) => new bool();

  [Token(Token = "0x60008D6")]
  [Address(RVA = "0xE57380", Offset = "0xE56180", VA = "0x10E57380")]
  public SerializeValue[] GetFields(int group) => (SerializeValue[]) null;

  [Token(Token = "0x60008D7")]
  [Address(RVA = "0xE56F40", Offset = "0xE55D40", VA = "0x10E56F40")]
  public void GetField(string key, ref bool result)
  {
  }

  [Token(Token = "0x60008D8")]
  [Address(RVA = "0xE56F80", Offset = "0xE55D80", VA = "0x10E56F80")]
  public void GetField(string key, ref bool result, bool defaultValue)
  {
  }

  [Token(Token = "0x60008D9")]
  [Address(RVA = "0xE56980", Offset = "0xE55780", VA = "0x10E56980")]
  public bool GetBool(string key) => new bool();

  [Token(Token = "0x60008DA")]
  [Address(RVA = "0xE56950", Offset = "0xE55750", VA = "0x10E56950")]
  public bool GetBool(string key, bool defaultValue) => new bool();

  [Token(Token = "0x60008DB")]
  [Address(RVA = "0xE56AE0", Offset = "0xE558E0", VA = "0x10E56AE0")]
  public void GetField(string key, ref int result)
  {
  }

  [Token(Token = "0x60008DC")]
  [Address(RVA = "0xE56D30", Offset = "0xE55B30", VA = "0x10E56D30")]
  public void GetField(string key, ref int result, int defaultValue)
  {
  }

  [Token(Token = "0x60008DD")]
  [Address(RVA = "0xE57760", Offset = "0xE56560", VA = "0x10E57760")]
  public int GetInt(string key) => new int();

  [Token(Token = "0x60008DE")]
  [Address(RVA = "0xE57730", Offset = "0xE56530", VA = "0x10E57730")]
  public int GetInt(string key, int defaultValue) => new int();

  [Token(Token = "0x60008DF")]
  [Address(RVA = "0xE56B70", Offset = "0xE55970", VA = "0x10E56B70")]
  public void GetField(string key, ref long result)
  {
  }

  [Token(Token = "0x60008E0")]
  [Address(RVA = "0xE57280", Offset = "0xE56080", VA = "0x10E57280")]
  public void GetField(string key, ref long result, long defaultValue)
  {
  }

  [Token(Token = "0x60008E1")]
  [Address(RVA = "0xE57920", Offset = "0xE56720", VA = "0x10E57920")]
  public long GetLong(string key) => new long();

  [Token(Token = "0x60008E2")]
  [Address(RVA = "0xE57960", Offset = "0xE56760", VA = "0x10E57960")]
  public long GetLong(string key, long defaultValue) => new long();

  [Token(Token = "0x60008E3")]
  [Address(RVA = "0xE56A50", Offset = "0xE55850", VA = "0x10E56A50")]
  public void GetField(string key, ref float result)
  {
  }

  [Token(Token = "0x60008E4")]
  [Address(RVA = "0xE57150", Offset = "0xE55F50", VA = "0x10E57150")]
  public void GetField(string key, ref float result, float defaultValue)
  {
  }

  [Token(Token = "0x60008E5")]
  [Address(RVA = "0xE574A0", Offset = "0xE562A0", VA = "0x10E574A0")]
  public float GetFloat(string key) => new float();

  [Token(Token = "0x60008E6")]
  [Address(RVA = "0xE57470", Offset = "0xE56270", VA = "0x10E57470")]
  public float GetFloat(string key, float defaultValue) => new float();

  [Token(Token = "0x60008E7")]
  [Address(RVA = "0xE570F0", Offset = "0xE55EF0", VA = "0x10E570F0")]
  public void GetField(string key, ref string result)
  {
  }

  [Token(Token = "0x60008E8")]
  [Address(RVA = "0xE56A90", Offset = "0xE55890", VA = "0x10E56A90")]
  public void GetField(string key, ref string result, string defaultValue)
  {
  }

  [Token(Token = "0x60008E9")]
  [Address(RVA = "0xE57A50", Offset = "0xE56850", VA = "0x10E57A50")]
  public string GetString(string key) => (string) null;

  [Token(Token = "0x60008EA")]
  [Address(RVA = "0xE57AA0", Offset = "0xE568A0", VA = "0x10E57AA0")]
  public string GetString(string key, string defaultValue) => (string) null;

  [Token(Token = "0x60008EB")]
  [Address(RVA = "0xE571E0", Offset = "0xE55FE0", VA = "0x10E571E0")]
  public void GetField(string key, ref Vector2 result)
  {
  }

  [Token(Token = "0x60008EC")]
  [Address(RVA = "0xE571A0", Offset = "0xE55FA0", VA = "0x10E571A0")]
  public void GetField(string key, ref Vector2 result, Vector2 defaultValue)
  {
  }

  [Token(Token = "0x60008ED")]
  [Address(RVA = "0xE57CB0", Offset = "0xE56AB0", VA = "0x10E57CB0")]
  public Vector2 GetVector2(string key) => new Vector2();

  [Token(Token = "0x60008EE")]
  [Address(RVA = "0xE57D30", Offset = "0xE56B30", VA = "0x10E57D30")]
  public Vector2 GetVector2(string key, Vector2 defaultValue) => new Vector2();

  [Token(Token = "0x60008EF")]
  [Address(RVA = "0xE56E10", Offset = "0xE55C10", VA = "0x10E56E10")]
  public void GetField(string key, ref Vector3 result)
  {
  }

  [Token(Token = "0x60008F0")]
  [Address(RVA = "0xE56DC0", Offset = "0xE55BC0", VA = "0x10E56DC0")]
  public void GetField(string key, ref Vector3 result, Vector3 defaultValue)
  {
  }

  [Token(Token = "0x60008F1")]
  [Address(RVA = "0xE57DC0", Offset = "0xE56BC0", VA = "0x10E57DC0")]
  public Vector3 GetVector3(string key) => new Vector3();

  [Token(Token = "0x60008F2")]
  [Address(RVA = "0xE57D60", Offset = "0xE56B60", VA = "0x10E57D60")]
  public Vector3 GetVector3(string key, Vector3 defaultValue) => new Vector3();

  [Token(Token = "0x60008F3")]
  [Address(RVA = "0xE57310", Offset = "0xE56110", VA = "0x10E57310")]
  public void GetField(string key, ref Vector4 result)
  {
  }

  [Token(Token = "0x60008F4")]
  [Address(RVA = "0xE56FC0", Offset = "0xE55DC0", VA = "0x10E56FC0")]
  public void GetField(string key, ref Vector4 result, Vector4 defaultValue)
  {
  }

  [Token(Token = "0x60008F5")]
  [Address(RVA = "0xE57E50", Offset = "0xE56C50", VA = "0x10E57E50")]
  public Vector4 GetVector4(string key) => new Vector4();

  [Token(Token = "0x60008F6")]
  [Address(RVA = "0xE57EC0", Offset = "0xE56CC0", VA = "0x10E57EC0")]
  public Vector4 GetVector4(string key, Vector4 defaultValue) => new Vector4();

  [Token(Token = "0x60008F7")]
  [Address(RVA = "0xE572C0", Offset = "0xE560C0", VA = "0x10E572C0")]
  public void GetField(string key, ref GameObject result)
  {
  }

  [Token(Token = "0x60008F8")]
  [Address(RVA = "0xE56EF0", Offset = "0xE55CF0", VA = "0x10E56EF0")]
  public void GetField(string key, ref GameObject result, GameObject defaultValue)
  {
  }

  [Token(Token = "0x60008F9")]
  [Address(RVA = "0xE57510", Offset = "0xE56310", VA = "0x10E57510")]
  public GameObject GetGameObject(string key) => (GameObject) null;

  [Token(Token = "0x60008FA")]
  [Address(RVA = "0xE574E0", Offset = "0xE562E0", VA = "0x10E574E0")]
  public GameObject GetGameObject(string key, GameObject defaultValue) => (GameObject) null;

  [Token(Token = "0x60008FB")]
  [Address(RVA = "0xE56EA0", Offset = "0xE55CA0", VA = "0x10E56EA0")]
  public void GetField(string key, ref Text result)
  {
  }

  [Token(Token = "0x60008FC")]
  [Address(RVA = "0xE56CE0", Offset = "0xE55AE0", VA = "0x10E56CE0")]
  public void GetField(string key, ref Text result, Text defaultValue)
  {
  }

  [Token(Token = "0x60008FD")]
  [Address(RVA = "0xE57BC0", Offset = "0xE569C0", VA = "0x10E57BC0")]
  public Text GetUILabel(string key) => (Text) null;

  [Token(Token = "0x60008FE")]
  [Address(RVA = "0xE57B90", Offset = "0xE56990", VA = "0x10E57B90")]
  public Text GetUILabel(string key, Text defaultValue) => (Text) null;

  [Token(Token = "0x60008FF")]
  [Address(RVA = "0xE56A00", Offset = "0xE55800", VA = "0x10E56A00")]
  public void GetField(string key, ref Image result)
  {
  }

  [Token(Token = "0x6000900")]
  [Address(RVA = "0xE56C90", Offset = "0xE55A90", VA = "0x10E56C90")]
  public void GetField(string key, ref Image result, Image defaultValue)
  {
  }

  [Token(Token = "0x6000901")]
  [Address(RVA = "0xE57B60", Offset = "0xE56960", VA = "0x10E57B60")]
  public Image GetUIImage(string key) => (Image) null;

  [Token(Token = "0x6000902")]
  [Address(RVA = "0xE57B30", Offset = "0xE56930", VA = "0x10E57B30")]
  public Image GetUIImage(string key, Image defaultValue) => (Image) null;

  [Token(Token = "0x6000903")]
  [Address(RVA = "0xE570A0", Offset = "0xE55EA0", VA = "0x10E570A0")]
  public void GetField(string key, ref Button result)
  {
  }

  [Token(Token = "0x6000904")]
  [Address(RVA = "0xE57050", Offset = "0xE55E50", VA = "0x10E57050")]
  public void GetField(string key, ref Button result, Button defaultValue)
  {
  }

  [Token(Token = "0x6000905")]
  [Address(RVA = "0xE57AD0", Offset = "0xE568D0", VA = "0x10E57AD0")]
  public Button GetUIButton(string key) => (Button) null;

  [Token(Token = "0x6000906")]
  [Address(RVA = "0xE57B00", Offset = "0xE56900", VA = "0x10E57B00")]
  public Button GetUIButton(string key, Button defaultValue) => (Button) null;

  [Token(Token = "0x6000907")]
  [Address(RVA = "0xE56D70", Offset = "0xE55B70", VA = "0x10E56D70")]
  public void GetField(string key, ref Toggle result)
  {
  }

  [Token(Token = "0x6000908")]
  [Address(RVA = "0xE569B0", Offset = "0xE557B0", VA = "0x10E569B0")]
  public void GetField(string key, ref Toggle result, Toggle defaultValue)
  {
  }

  [Token(Token = "0x6000909")]
  [Address(RVA = "0xE57C80", Offset = "0xE56A80", VA = "0x10E57C80")]
  public Toggle GetUIToggle(string key) => (Toggle) null;

  [Token(Token = "0x600090A")]
  [Address(RVA = "0xE57C50", Offset = "0xE56A50", VA = "0x10E57C50")]
  public Toggle GetUIToggle(string key, Toggle defaultValue) => (Toggle) null;

  [Token(Token = "0x600090B")]
  [Address(RVA = "0xE57000", Offset = "0xE55E00", VA = "0x10E57000")]
  public void GetField(string key, ref ScriptableObject result)
  {
  }

  [Token(Token = "0x600090C")]
  [Address(RVA = "0xE56B20", Offset = "0xE55920", VA = "0x10E56B20")]
  public void GetField(string key, ref ScriptableObject result, ScriptableObject defaultValue)
  {
  }

  [Token(Token = "0x600090D")]
  [Address(RVA = "0xE57A20", Offset = "0xE56820", VA = "0x10E57A20")]
  public ScriptableObject GetScriptableObject(string key) => (ScriptableObject) null;

  [Token(Token = "0x600090E")]
  [Address(RVA = "0xE579F0", Offset = "0xE567F0", VA = "0x10E579F0")]
  public ScriptableObject GetScriptableObject(string key, ScriptableObject defaultValue)
  {
    return (ScriptableObject) null;
  }

  [Token(Token = "0x600090F")]
  [Address(RVA = "0xE57570", Offset = "0xE56370", VA = "0x10E57570")]
  public object GetGlobal(string key) => (object) null;

  [Token(Token = "0x6000910")]
  [Address(RVA = "0xE57540", Offset = "0xE56340", VA = "0x10E57540")]
  public object GetGlobal(string key, object defaultValue) => (object) null;

  [Token(Token = "0x6000911")]
  [Address(RVA = "0xE579C0", Offset = "0xE567C0", VA = "0x10E579C0")]
  public object GetObject(string key) => (object) null;

  [Token(Token = "0x6000912")]
  [Address(RVA = "0xE57990", Offset = "0xE56790", VA = "0x10E57990")]
  public object GetObject(string key, object defaultValue) => (object) null;

  [Token(Token = "0x6000913")]
  public T GetObject<T>(string key) => (T) null;

  [Token(Token = "0x6000914")]
  public T GetObject<T>(string key, T defaultValue) => (T) null;

  [Token(Token = "0x6000915")]
  public T GetEnum<T>(string key) => (T) null;

  [Token(Token = "0x6000916")]
  public T GetEnum<T>(string key, T defaultValue) => (T) null;

  [Token(Token = "0x6000917")]
  public T GetComponent<T>(string key) where T : Component => (T) null;

  [Token(Token = "0x6000918")]
  public T GetComponent<T>(string key, T defaultValue) where T : Component => (T) null;

  [Token(Token = "0x6000919")]
  public T GetDataSource<T>(string key) => (T) null;

  [Token(Token = "0x600091A")]
  public T GetDataSource<T>(string key, T defaultValue) => (T) null;

  [Token(Token = "0x600091B")]
  public T GetContentParam<T>(string key) where T : ContentSource.Param => (T) null;

  [Token(Token = "0x600091C")]
  public T GetContentParam<T>(string key, T defaultValue) where T : ContentSource.Param => (T) null;

  [Token(Token = "0x600091D")]
  [Address(RVA = "0xE57BF0", Offset = "0xE569F0", VA = "0x10E57BF0")]
  public bool GetUIOn(string key) => new bool();

  [Token(Token = "0x600091E")]
  [Address(RVA = "0xE57C20", Offset = "0xE56A20", VA = "0x10E57C20")]
  public bool GetUIOn(string key, bool defaultValue) => new bool();

  [Token(Token = "0x600091F")]
  [Address(RVA = "0xE57F10", Offset = "0xE56D10", VA = "0x10E57F10")]
  public bool HasField(string key) => new bool();

  [Token(Token = "0x6000920")]
  [Address(RVA = "0xE58370", Offset = "0xE57170", VA = "0x10E58370")]
  public bool IsActive(string key) => new bool();

  [Token(Token = "0x2000158")]
  public class Group
  {
    [Token(Token = "0x4000695")]
    [FieldOffset(Offset = "0x8")]
    public int index;
    [Token(Token = "0x4000696")]
    [FieldOffset(Offset = "0xC")]
    public List<SerializeValue> list;

    [Token(Token = "0x6000921")]
    [Address(RVA = "0xE4E250", Offset = "0xE4D050", VA = "0x10E4E250")]
    public Group()
    {
    }
  }
}
