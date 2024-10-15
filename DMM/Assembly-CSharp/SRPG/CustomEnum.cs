// Decompiled with JetBrains decompiler
// Type: SRPG.CustomEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200115B")]
  public class CustomEnum : PropertyAttribute
  {
    [Token(Token = "0x4003EDC")]
    [FieldOffset(Offset = "0xC")]
    public System.Type EnumType;
    [Token(Token = "0x4003EDD")]
    [FieldOffset(Offset = "0x10")]
    public int DefaultValue;

    [Token(Token = "0x60049FE")]
    [Address(RVA = "0x11FF320", Offset = "0x11FE120", VA = "0x111FF320")]
    public CustomEnum(System.Type enumType, int defaultValue)
    {
    }
  }
}
