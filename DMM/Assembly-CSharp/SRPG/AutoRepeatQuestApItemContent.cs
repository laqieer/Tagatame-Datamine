// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestApItemContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200205E")]
  [AddComponentMenu("UI/AutoRepeatQuest/AutoRepeatQuestApItemContent")]
  public class AutoRepeatQuestApItemContent : MonoBehaviour
  {
    [Token(Token = "0x4008B1C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle mToggle;
    [Token(Token = "0x4008B1D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mPriorityImageArray;
    [Token(Token = "0x4008B1E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mApValueText;
    [Token(Token = "0x4008B1F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mLastPriorityImage;
    [Token(Token = "0x4008B20")]
    [FieldOffset(Offset = "0x1C")]
    private ItemData mItemData;

    [Token(Token = "0x17001311")]
    public string ItemIname
    {
      [Token(Token = "0x6008674"), Address(RVA = "0x47D2C0", Offset = "0x47C0C0", VA = "0x1047D2C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001312")]
    public int PriorityImageMax
    {
      [Token(Token = "0x6008675"), Address(RVA = "0x47D310", Offset = "0x47C110", VA = "0x1047D310")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008676")]
    [Address(RVA = "0x47CFD0", Offset = "0x47BDD0", VA = "0x1047CFD0")]
    public void Init(ItemParam item_param)
    {
    }

    [Token(Token = "0x6008677")]
    [Address(RVA = "0x47D110", Offset = "0x47BF10", VA = "0x1047D110")]
    public void Refresh(int priority, bool is_last_priority = false)
    {
    }

    [Token(Token = "0x6008678")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AutoRepeatQuestApItemContent()
    {
    }
  }
}
