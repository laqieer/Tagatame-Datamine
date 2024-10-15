// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestChapterSelectorItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002809")]
  public class PointQuestChapterSelectorItem : MonoBehaviour
  {
    [Token(Token = "0x400BE98")]
    private const string PREFAB_PATH = "QuestChapters_point/";
    [Token(Token = "0x400BE99")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SRPG_Button SelectBtn;
    [Token(Token = "0x400BE9A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RectTransform ChangeScaleObj;
    [Token(Token = "0x400BE9B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image ChangeColorImage;
    [Token(Token = "0x400BE9C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400BE9D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Animator SelectAnimator;
    [Token(Token = "0x400BE9E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ColorAnimation CenterAnim;
    [Token(Token = "0x400BE9F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [Tooltip("遷移アニメーション開始フラグキー名")]
    private string StartAnimFlagName;
    [Token(Token = "0x400BEA0")]
    [FieldOffset(Offset = "0x28")]
    [Tooltip("遷移アニメーション完了ステート名")]
    [SerializeField]
    private string EndAnimStateName;
    [Token(Token = "0x400BEA1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [Tooltip("オブジェクトが変化開始する中心点からの距離")]
    private float ChangeObjDistance;
    [Token(Token = "0x400BEA2")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("中央に来たときに大きさ")]
    [SerializeField]
    private float CenterScale;
    [Token(Token = "0x400BEA3")]
    [FieldOffset(Offset = "0x34")]
    [Tooltip("中央以外に来たときに大きさ")]
    [SerializeField]
    private float OtherScale;
    [Token(Token = "0x400BEA4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Tooltip("中心アニメーション設定が表示される距離")]
    private float CenterAnimDistance;
    [Token(Token = "0x400BEA5")]
    [FieldOffset(Offset = "0x3C")]
    private PointQuestChapterSelectorView mSelectorView;
    [Token(Token = "0x400BEA6")]
    [FieldOffset(Offset = "0x40")]
    private ChapterParam mChapterParam;
    [Token(Token = "0x400BEA7")]
    [FieldOffset(Offset = "0x44")]
    private int mIndex;
    [Token(Token = "0x400BEA8")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsOutOfPeriod;
    [Token(Token = "0x400BEA9")]
    [FieldOffset(Offset = "0x49")]
    private bool mIsLiberation;
    [Token(Token = "0x400BEAA")]
    [FieldOffset(Offset = "0x4C")]
    private Vector3 mDefaultScale;
    [Token(Token = "0x400BEAB")]
    [FieldOffset(Offset = "0x58")]
    private bool mIsCenterAnim;
    [Token(Token = "0x400BEAC")]
    [FieldOffset(Offset = "0x5C")]
    private PointQuestChapterSelectorItemModel mModel;

    [Token(Token = "0x170018C7")]
    public ChapterParam ChapterParam
    {
      [Token(Token = "0x600B4D0"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (ChapterParam) null;
      }
    }

    [Token(Token = "0x170018C8")]
    public int Index
    {
      [Token(Token = "0x600B4D1"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170018C9")]
    public bool IsOutOfPeriod
    {
      [Token(Token = "0x600B4D2"), Address(RVA = "0x661B10", Offset = "0x660910", VA = "0x10661B10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170018CA")]
    public bool IsLiberation
    {
      [Token(Token = "0x600B4D3"), Address(RVA = "0x2B5EE0", Offset = "0x2B4CE0", VA = "0x102B5EE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B4D4")]
    [Address(RVA = "0x7B3570", Offset = "0x7B2370", VA = "0x107B3570")]
    public void SetItem(
      PointQuestChapterSelectorView _view,
      ChapterParam chapter_param,
      int _index,
      bool is_out_of_period,
      bool is_liberation,
      bool _is_circulation_obj = false)
    {
    }

    [Token(Token = "0x600B4D5")]
    [Address(RVA = "0x7B3500", Offset = "0x7B2300", VA = "0x107B3500")]
    private void OnClick()
    {
    }

    [Token(Token = "0x600B4D6")]
    [Address(RVA = "0x7B3410", Offset = "0x7B2210", VA = "0x107B3410")]
    private void Draw()
    {
    }

    [Token(Token = "0x600B4D7")]
    [Address(RVA = "0x7B31B0", Offset = "0x7B1FB0", VA = "0x107B31B0")]
    public void ChangeScale(float _center_pos)
    {
    }

    [Token(Token = "0x600B4D8")]
    [Address(RVA = "0x7B2F60", Offset = "0x7B1D60", VA = "0x107B2F60")]
    public void ChangeAlpha(float _center_pos)
    {
    }

    [Token(Token = "0x600B4D9")]
    [Address(RVA = "0x7B38E0", Offset = "0x7B26E0", VA = "0x107B38E0")]
    public void StartAnimation()
    {
    }

    [Token(Token = "0x600B4DA")]
    [Address(RVA = "0x7B33A0", Offset = "0x7B21A0", VA = "0x107B33A0")]
    private IEnumerator CheckAnimation() => (IEnumerator) null;

    [Token(Token = "0x600B4DB")]
    [Address(RVA = "0x7B3490", Offset = "0x7B2290", VA = "0x107B3490")]
    private void OnApplicationFocus(bool _status)
    {
    }

    [Token(Token = "0x600B4DC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestChapterSelectorItem()
    {
    }
  }
}
