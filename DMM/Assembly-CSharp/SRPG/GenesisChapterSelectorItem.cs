// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisChapterSelectorItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024E7")]
  [AddComponentMenu("UI/Genesis/GenesisChapterSelectorItem")]
  public class GenesisChapterSelectorItem : MonoBehaviour
  {
    [Token(Token = "0x400A88B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextTitle;
    [Token(Token = "0x400A88C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform TrParentBanner;
    [Token(Token = "0x400A88D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoLock;
    [Token(Token = "0x400A88E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Space(5f)]
    private SRPG_Button SelectBtn;
    [Token(Token = "0x400A88F")]
    [FieldOffset(Offset = "0x1C")]
    private GenesisChapterParam mChapterParam;
    [Token(Token = "0x400A890")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsOutOfPeriod;
    [Token(Token = "0x400A891")]
    [FieldOffset(Offset = "0x21")]
    private bool mIsLiberation;

    [Token(Token = "0x170016A9")]
    public GenesisChapterParam ChapterParam
    {
      [Token(Token = "0x600A202"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (GenesisChapterParam) null;
      }
    }

    [Token(Token = "0x170016AA")]
    public bool IsOutOfPeriod
    {
      [Token(Token = "0x600A203"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016AB")]
    public bool IsLiberation
    {
      [Token(Token = "0x600A204"), Address(RVA = "0x305F20", Offset = "0x304D20", VA = "0x10305F20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A205")]
    [Address(RVA = "0x63AB20", Offset = "0x639920", VA = "0x1063AB20")]
    public void SetItem(
      GenesisChapterParam chapter_param,
      UnityAction action,
      bool is_out_of_period,
      bool is_liberation)
    {
    }

    [Token(Token = "0x600A206")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisChapterSelectorItem()
    {
    }
  }
}
