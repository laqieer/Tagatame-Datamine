// Decompiled with JetBrains decompiler
// Type: SRPG.RuneContinueEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002974")]
  [AddComponentMenu("UI/Rune/RuneContinueEnhance")]
  public class RuneContinueEnhance : MonoBehaviour
  {
    [Token(Token = "0x400C7EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly string SVB_KEY_IMG_ARRAY_ON;
    [Token(Token = "0x400C7EC")]
    [FieldOffset(Offset = "0x10")]
    private readonly string SVB_KEY_IMG_ARRAY_OFF;
    [Token(Token = "0x400C7ED")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int[] mPlusCount;
    [Token(Token = "0x400C7EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int[] mEnhanceCount;
    [Token(Token = "0x400C7EF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle mPlusCountTemplate;
    [Token(Token = "0x400C7F0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle mEnhanceCountTemplate;
    [Token(Token = "0x400C7F1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mSelectedPlusCountText;
    [Token(Token = "0x400C7F2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mSelectedEnhanceCountText;
    [Token(Token = "0x400C7F3")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Toggle mPlusCountTab;
    [Token(Token = "0x400C7F4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle mEnhanceCountTab;
    [Token(Token = "0x400C7F5")]
    [FieldOffset(Offset = "0x34")]
    private List<Toggle> mCreatedPlusCountToggles;
    [Token(Token = "0x400C7F6")]
    [FieldOffset(Offset = "0x38")]
    private List<Toggle> mCreatedEnhanceCountToggles;
    [Token(Token = "0x400C7F7")]
    [FieldOffset(Offset = "0x3C")]
    private int mSelectedPlusCount;
    [Token(Token = "0x400C7F8")]
    [FieldOffset(Offset = "0x40")]
    private int mSelectedEnhanceCount;
    [Token(Token = "0x400C7F9")]
    [FieldOffset(Offset = "0x44")]
    private BindRuneData mTargetRune;

    [Token(Token = "0x1700197C")]
    public int SelectedPlusCount
    {
      [Token(Token = "0x600BBAC"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700197D")]
    public int SelectedEnhanceCount
    {
      [Token(Token = "0x600BBAD"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600BBAE")]
    [Address(RVA = "0x830920", Offset = "0x82F720", VA = "0x10830920")]
    public void Init(BindRuneData bind_rune)
    {
    }

    [Token(Token = "0x600BBAF")]
    [Address(RVA = "0x830CA0", Offset = "0x82FAA0", VA = "0x10830CA0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BBB0")]
    [Address(RVA = "0x8304C0", Offset = "0x82F2C0", VA = "0x108304C0")]
    private void CreateEnhanceUI(int default_plus_count_index, int default_enhance_count_index)
    {
    }

    [Token(Token = "0x600BBB1")]
    [Address(RVA = "0x830E20", Offset = "0x82FC20", VA = "0x10830E20")]
    private void SetImageArray(GameObject obj, int img_index)
    {
    }

    [Token(Token = "0x600BBB2")]
    [Address(RVA = "0x830850", Offset = "0x82F650", VA = "0x10830850")]
    public void GetEnhanceSettingParam(ref RuneEnhanceSettings.eEnhanceMode mode, ref int value)
    {
    }

    [Token(Token = "0x600BBB3")]
    [Address(RVA = "0x830B70", Offset = "0x82F970", VA = "0x10830B70")]
    public void OnClickPlusCountToggle(Toggle self)
    {
    }

    [Token(Token = "0x600BBB4")]
    [Address(RVA = "0x830A40", Offset = "0x82F840", VA = "0x10830A40")]
    public void OnClickEnhanceCountToggle(Toggle self)
    {
    }

    [Token(Token = "0x600BBB5")]
    [Address(RVA = "0x830FE0", Offset = "0x82FDE0", VA = "0x10830FE0")]
    public RuneContinueEnhance()
    {
    }
  }
}
