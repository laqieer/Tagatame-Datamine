// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureBookItemRewardNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F76")]
  public class AdventureBookItemRewardNode : ContentNode
  {
    [Token(Token = "0x40084DB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject GoNotOpen;
    [Token(Token = "0x40084DC")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Animator Anim;
    [Token(Token = "0x40084DD")]
    [FieldOffset(Offset = "0x38")]
    private AdventureBookItemRewardParam mParam;

    [Token(Token = "0x1700128B")]
    public AdventureBookItemRewardParam Param
    {
      [Token(Token = "0x6008140"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (AdventureBookItemRewardParam) null;
      }
    }

    [Token(Token = "0x6008141")]
    [Address(RVA = "0x41BC40", Offset = "0x41AA40", VA = "0x1041BC40")]
    public void Setup(AdventureBookItemRewardParam param)
    {
    }

    [Token(Token = "0x6008142")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public AdventureBookItemRewardNode()
    {
    }
  }
}
