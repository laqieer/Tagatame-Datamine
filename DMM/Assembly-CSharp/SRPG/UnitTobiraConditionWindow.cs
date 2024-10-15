// Decompiled with JetBrains decompiler
// Type: SRPG.UnitTobiraConditionWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D08")]
  [AddComponentMenu("UI/UnitTobiraConditionWindow")]
  public class UnitTobiraConditionWindow : MonoBehaviour
  {
    [Token(Token = "0x400E004")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string HAS_UNIT_OBJECT_NAME;
    [Token(Token = "0x400E005")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string NOT_HAS_UNIT_OBJECT_NAME;
    [Token(Token = "0x400E006")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string NOT_OPEN_JOB_OBJECT_NAME;
    [Token(Token = "0x400E007")]
    [FieldOffset(Offset = "0xC")]
    private static readonly string NOT_OPEN_TOBIRA_OBJECT_NAME;
    [Token(Token = "0x400E008")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string VALUE_TEXT_NAME;
    [Token(Token = "0x400E009")]
    [FieldOffset(Offset = "0x14")]
    private static readonly string VALUE_MAX_TEXT_NAME;
    [Token(Token = "0x400E00A")]
    [FieldOffset(Offset = "0x18")]
    private static readonly string JOB_LEVEL_TEXT_PAREANT_NAME;
    [Token(Token = "0x400E00B")]
    [FieldOffset(Offset = "0x1C")]
    private static readonly string JOB_LEVEL_TEXT_NAME;
    [Token(Token = "0x400E00C")]
    [FieldOffset(Offset = "0x20")]
    private static readonly string JOB_LEVEL_MAX_TEXT_NAME;
    [Token(Token = "0x400E00D")]
    [FieldOffset(Offset = "0x24")]
    private static readonly string STRING_FORMAT_CONDS_CLEAR;
    [Token(Token = "0x400E00E")]
    [FieldOffset(Offset = "0x28")]
    private static readonly string STRING_FORMAT_CONDS_NOT_CLEAR;
    [Token(Token = "0x400E00F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mConditionObjectParent;
    [Token(Token = "0x400E010")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mConditionObjectTemplate;
    [Token(Token = "0x400E011")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mConditionLayoutParent;
    [Token(Token = "0x400E012")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mTitleTextObject;
    [Token(Token = "0x400E013")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform mTitleTextObjectParent;
    [Token(Token = "0x400E014")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ImageArray mIconImageArray;
    [Token(Token = "0x400E015")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼条件表示用のテンプレート")]
    [SerializeField]
    private GameObject mLayout_UnitLevel;
    [Token(Token = "0x400E016")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mLayout_UnitAwake;
    [Token(Token = "0x400E017")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mLayout_JobLevel;
    [Token(Token = "0x400E018")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mLayout_TobiraLevel;
    [Token(Token = "0x400E019")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mLayout_TobiraOpen;
    [Token(Token = "0x400E01A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mLayout_None;
    [Token(Token = "0x400E01B")]
    [FieldOffset(Offset = "0x3C")]
    private UnitTobiraConditionWindow.ViewParam mViewParam;
    [Token(Token = "0x400E01C")]
    [FieldOffset(Offset = "0x40")]
    private GameObject[] mLayoutObjects;

    [Token(Token = "0x600D1A6")]
    [Address(RVA = "0x9CB650", Offset = "0x9CA450", VA = "0x109CB650")]
    private void Start()
    {
    }

    [Token(Token = "0x600D1A7")]
    [Address(RVA = "0x9CAFC0", Offset = "0x9C9DC0", VA = "0x109CAFC0")]
    private void CreateLayout(ConditionsResult conds)
    {
    }

    [Token(Token = "0x600D1A8")]
    [Address(RVA = "0x9CA030", Offset = "0x9C8E30", VA = "0x109CA030")]
    private void CreateLayoutObject(UnitTobiraConditionWindow.ViewParam view_param)
    {
    }

    [Token(Token = "0x600D1A9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitTobiraConditionWindow()
    {
    }

    [Token(Token = "0x600D1AA")]
    [Address(RVA = "0x9CB9D0", Offset = "0x9CA7D0", VA = "0x109CB9D0")]
    static UnitTobiraConditionWindow()
    {
    }

    [Token(Token = "0x2002D09")]
    private enum eLayoutType
    {
      [Token(Token = "0x400E01E")] None,
      [Token(Token = "0x400E01F")] UnitLevel,
      [Token(Token = "0x400E020")] UnitAwake,
      [Token(Token = "0x400E021")] JobLevel,
      [Token(Token = "0x400E022")] TobiraLevel,
      [Token(Token = "0x400E023")] TobiraOpen,
      [Token(Token = "0x400E024")] MAX,
    }

    [Token(Token = "0x2002D0A")]
    private class ViewParam
    {
      [Token(Token = "0x400E025")]
      [FieldOffset(Offset = "0x8")]
      public UnitTobiraConditionWindow.eLayoutType type;
      [Token(Token = "0x400E026")]
      [FieldOffset(Offset = "0xC")]
      public string title;
      [Token(Token = "0x400E027")]
      [FieldOffset(Offset = "0x10")]
      public string value;
      [Token(Token = "0x400E028")]
      [FieldOffset(Offset = "0x14")]
      public string value_max;
      [Token(Token = "0x400E029")]
      [FieldOffset(Offset = "0x18")]
      public bool is_clear;
      [Token(Token = "0x400E02A")]
      [FieldOffset(Offset = "0x19")]
      public bool has_unit;
      [Token(Token = "0x400E02B")]
      [FieldOffset(Offset = "0x1C")]
      public UnitData unit_data;
      [Token(Token = "0x400E02C")]
      [FieldOffset(Offset = "0x20")]
      public JobParam job_param;
      [Token(Token = "0x400E02D")]
      [FieldOffset(Offset = "0x24")]
      public TobiraData tobira_data;

      [Token(Token = "0x600D1AB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ViewParam()
      {
      }
    }
  }
}
