// Decompiled with JetBrains decompiler
// Type: SRPG.UnitGetWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C2E")]
  [AddComponentMenu("UI/UnitGetWindow")]
  public class UnitGetWindow : MonoBehaviour
  {
    [Token(Token = "0x400DAB7")]
    [FieldOffset(Offset = "0xC")]
    public GameObject PopupUnit;
    [Token(Token = "0x400DAB8")]
    [FieldOffset(Offset = "0x10")]
    [Space(5f)]
    public GameObject PopupAnimation;
    [Token(Token = "0x400DAB9")]
    [FieldOffset(Offset = "0x14")]
    public string PopupRarityVar;
    [Token(Token = "0x400DABA")]
    [FieldOffset(Offset = "0x18")]
    public string PopupShardVar;
    [Token(Token = "0x400DABB")]
    [FieldOffset(Offset = "0x1C")]
    [Space(5f)]
    public GameObject ShardNum;
    [Token(Token = "0x400DABC")]
    [FieldOffset(Offset = "0x20")]
    [Space(10f)]
    public GameObject ShardGauge;
    [Token(Token = "0x400DABD")]
    [FieldOffset(Offset = "0x24")]
    [Space(5f)]
    public GameObject ShardAnimation;
    [Token(Token = "0x400DABE")]
    [FieldOffset(Offset = "0x28")]
    [Space(5f)]
    public string EndShardState;
    [Token(Token = "0x400DABF")]
    [FieldOffset(Offset = "0x2C")]
    [Space(10f)]
    public GameObject NormalGetEffect;
    [Token(Token = "0x400DAC0")]
    [FieldOffset(Offset = "0x30")]
    public GameObject RareGetEffect;
    [Token(Token = "0x400DAC1")]
    [FieldOffset(Offset = "0x34")]
    public GameObject SRareGetEffect;
    [Token(Token = "0x400DAC2")]
    [FieldOffset(Offset = "0x38")]
    private UnitData mUnitData;
    [Token(Token = "0x400DAC3")]
    [FieldOffset(Offset = "0x3C")]
    private Animator mPopupAnimator;
    [Token(Token = "0x400DAC4")]
    [FieldOffset(Offset = "0x40")]
    private GetUnitShard mShardWindow;
    [Token(Token = "0x400DAC5")]
    [FieldOffset(Offset = "0x44")]
    private GameObject mCurrentGetEffect;
    [Token(Token = "0x400DAC6")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsEnd;
    [Token(Token = "0x400DAC7")]
    [FieldOffset(Offset = "0x49")]
    public bool isMaxShard;
    [Token(Token = "0x400DAC8")]
    [FieldOffset(Offset = "0x4A")]
    private bool mIsShardEnd;
    [Token(Token = "0x400DAC9")]
    [FieldOffset(Offset = "0x4B")]
    private bool mIsEffectEnd;
    [Token(Token = "0x400DACA")]
    [FieldOffset(Offset = "0x4C")]
    private bool mIsClickClose;

    [Token(Token = "0x17001B15")]
    public bool IsEnd
    {
      [Token(Token = "0x600CCA2"), Address(RVA = "0x661B10", Offset = "0x660910", VA = "0x10661B10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CCA3")]
    [Address(RVA = "0x977A60", Offset = "0x976860", VA = "0x10977A60")]
    public void Init(string unitId, bool isConver, int covertPieces)
    {
    }

    [Token(Token = "0x600CCA4")]
    [Address(RVA = "0x977FD0", Offset = "0x976DD0", VA = "0x10977FD0")]
    public void PlayAnim(bool isConver)
    {
    }

    [Token(Token = "0x600CCA5")]
    [Address(RVA = "0x977F50", Offset = "0x976D50", VA = "0x10977F50")]
    public void OnCloseClick()
    {
    }

    [Token(Token = "0x600CCA6")]
    [Address(RVA = "0x978250", Offset = "0x977050", VA = "0x10978250")]
    private void Update()
    {
    }

    [Token(Token = "0x600CCA7")]
    [Address(RVA = "0x978160", Offset = "0x976F60", VA = "0x10978160")]
    private void SpawnGetEffect(int rarity)
    {
    }

    [Token(Token = "0x600CCA8")]
    [Address(RVA = "0x978410", Offset = "0x977210", VA = "0x10978410")]
    public UnitGetWindow()
    {
    }
  }
}
