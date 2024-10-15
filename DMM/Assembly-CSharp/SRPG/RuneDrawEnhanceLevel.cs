// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawEnhanceLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200298C")]
  [AddComponentMenu("UI/Rune/RuneDrawEnhanceLevel")]
  public class RuneDrawEnhanceLevel : MonoBehaviour
  {
    [Token(Token = "0x400C8AA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mLevelGroup;
    [Token(Token = "0x400C8AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mLevelNow;
    [Token(Token = "0x400C8AC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mLevelNext;
    [Token(Token = "0x400C8AD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mEnhanceLevelGroup;
    [Token(Token = "0x400C8AE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mEnhanceLevelNow;
    [Token(Token = "0x400C8AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mEnhanceLevelNext;
    [Token(Token = "0x400C8B0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mEvoLevelGroup;
    [Token(Token = "0x400C8B1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mEvoLevelNow;
    [Token(Token = "0x400C8B2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text mEvoLevelNext;
    [Token(Token = "0x400C8B3")]
    [FieldOffset(Offset = "0x30")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400C8B4")]
    [FieldOffset(Offset = "0x34")]
    private int mAddLevel;
    [Token(Token = "0x400C8B5")]
    [FieldOffset(Offset = "0x38")]
    private int mChangeEnhanceLevel;
    [Token(Token = "0x400C8B6")]
    [FieldOffset(Offset = "0x3C")]
    private int mChangeEvoLevel;
    [Token(Token = "0x400C8B7")]
    [FieldOffset(Offset = "0x40")]
    private bool mIsBulk;

    [Token(Token = "0x600BC3B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BC3C")]
    [Address(RVA = "0x83F8D0", Offset = "0x83E6D0", VA = "0x1083F8D0")]
    public void SetDrawParam(BindRuneData rune_data, int add_level = 0)
    {
    }

    [Token(Token = "0x600BC3D")]
    [Address(RVA = "0x83F900", Offset = "0x83E700", VA = "0x1083F900")]
    public void SetDrawParam(
      BindRuneData rune_data,
      int change_enhance_level = 0,
      int change_evo_level = 0)
    {
    }

    [Token(Token = "0x600BC3E")]
    [Address(RVA = "0x83F540", Offset = "0x83E340", VA = "0x1083F540")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC3F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDrawEnhanceLevel()
    {
    }
  }
}
