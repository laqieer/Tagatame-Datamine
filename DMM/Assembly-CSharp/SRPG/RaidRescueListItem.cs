// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRescueListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028EC")]
  [AddComponentMenu("UI/Raid/RaidRescueListItem")]
  public class RaidRescueListItem : MonoBehaviour
  {
    [Token(Token = "0x400C4C5")]
    [FieldOffset(Offset = "0xC")]
    private int mIndex;

    [Token(Token = "0x17001956")]
    public int Index
    {
      [Token(Token = "0x600B937"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B938")]
    [Address(RVA = "0x805D20", Offset = "0x804B20", VA = "0x10805D20")]
    public void Setup(int index, RaidRescueMember member)
    {
    }

    [Token(Token = "0x600B939")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidRescueListItem()
    {
    }
  }
}
