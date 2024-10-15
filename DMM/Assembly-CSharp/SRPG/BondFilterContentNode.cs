// Decompiled with JetBrains decompiler
// Type: SRPG.BondFilterContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020AA")]
  public class BondFilterContentNode : ContentNode
  {
    [Token(Token = "0x4008CA7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnitIcon mSelectIcon;
    [Token(Token = "0x4008CA8")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mSelectObj;
    [Token(Token = "0x4008CA9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mUnitName;
    [Token(Token = "0x4008CAA")]
    [FieldOffset(Offset = "0x3C")]
    private DataSource mDataSource;

    [Token(Token = "0x60087EA")]
    [Address(RVA = "0x492CD0", Offset = "0x491AD0", VA = "0x10492CD0")]
    public bool Setup(bool is_select, UnitParam param) => new bool();

    [Token(Token = "0x60087EB")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public BondFilterContentNode()
    {
    }
  }
}
