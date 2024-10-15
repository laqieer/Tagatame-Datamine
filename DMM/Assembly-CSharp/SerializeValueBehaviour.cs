// Decompiled with JetBrains decompiler
// Type: SerializeValueBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000156")]
[AddComponentMenu("Common/SerializeValueBehaviour")]
public class SerializeValueBehaviour : MonoBehaviour
{
  [Token(Token = "0x4000693")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private SerializeValueList m_List;

  [Token(Token = "0x17000143")]
  public SerializeValueList list
  {
    [Token(Token = "0x6000899"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return (SerializeValueList) null;
    }
  }

  [Token(Token = "0x600089A")]
  [Address(RVA = "0xE558E0", Offset = "0xE546E0", VA = "0x10E558E0")]
  private void Awake()
  {
  }

  [Token(Token = "0x600089B")]
  [Address(RVA = "0xE55910", Offset = "0xE54710", VA = "0x10E55910")]
  public SerializeValueBehaviour()
  {
  }
}
