// Decompiled with JetBrains decompiler
// Type: SRPG.TutorialMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B9A")]
  [AddComponentMenu("UI/TutorialMask")]
  public class TutorialMask : MonoBehaviour
  {
    [Token(Token = "0x400D614")]
    private const string DESTROY_MASK_EVENT_NAME = "CLOSE_TUTORIAL_MASK";
    [Token(Token = "0x400D615")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mMask;
    [Token(Token = "0x400D616")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button mEnableArea;
    [Token(Token = "0x400D617")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button[] mDisableAreas;
    [Token(Token = "0x400D618")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mArrow;
    [Token(Token = "0x400D619")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mTextRoot;
    [Token(Token = "0x400D61A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mText;
    [Token(Token = "0x400D61B")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsFinishSetup;
    [Token(Token = "0x400D61C")]
    [FieldOffset(Offset = "0x28")]
    private RectTransform mMaskRectTransform;
    [Token(Token = "0x400D61D")]
    [FieldOffset(Offset = "0x2C")]
    private Vector3 mTargetWorldPos;
    [Token(Token = "0x400D61E")]
    [FieldOffset(Offset = "0x38")]
    private Vector3 mTargetScreenPos;
    [Token(Token = "0x400D61F")]
    [FieldOffset(Offset = "0x44")]
    private TutorialMask.eActionType mActionType;
    [Token(Token = "0x400D620")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsWorld2Screen;
    [Token(Token = "0x400D621")]
    [FieldOffset(Offset = "0x4C")]
    private float mNoResponseTime;
    [Token(Token = "0x400D622")]
    [FieldOffset(Offset = "0x50")]
    private Vector2 mMaskSize;
    [Token(Token = "0x400D623")]
    [FieldOffset(Offset = "0x58")]
    private Animator mAnimator;
    [Token(Token = "0x400D624")]
    [FieldOffset(Offset = "0x5C")]
    public TutorialMask.OpendMethod mOpendMethod;

    [Token(Token = "0x600C83E")]
    [Address(RVA = "0x9105E0", Offset = "0x90F3E0", VA = "0x109105E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C83F")]
    [Address(RVA = "0x9111D0", Offset = "0x90FFD0", VA = "0x109111D0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C840")]
    [Address(RVA = "0x910EA0", Offset = "0x90FCA0", VA = "0x10910EA0")]
    public void Setup(
      TutorialMask.eActionType act_type,
      Vector3 world_pos,
      bool is_world2screen,
      string text = null)
    {
    }

    [Token(Token = "0x600C841")]
    [Address(RVA = "0x3706B0", Offset = "0x36F4B0", VA = "0x103706B0")]
    public void SetupMaskSize(Vector2 size)
    {
    }

    [Token(Token = "0x600C842")]
    [Address(RVA = "0x910C20", Offset = "0x90FA20", VA = "0x10910C20")]
    private void Resize()
    {
    }

    [Token(Token = "0x600C843")]
    [Address(RVA = "0x910E80", Offset = "0x90FC80", VA = "0x10910E80")]
    public void SetupNoResponseTime(float second)
    {
    }

    [Token(Token = "0x600C844")]
    [Address(RVA = "0x910970", Offset = "0x90F770", VA = "0x10910970")]
    private void OnClick_EnableArea()
    {
    }

    [Token(Token = "0x600C845")]
    [Address(RVA = "0x910920", Offset = "0x90F720", VA = "0x10910920")]
    private void OnClick_DisableArea()
    {
    }

    [Token(Token = "0x600C846")]
    [Address(RVA = "0x9107E0", Offset = "0x90F5E0", VA = "0x109107E0")]
    private void MoveUnit()
    {
    }

    [Token(Token = "0x600C847")]
    [Address(RVA = "0x911100", Offset = "0x90FF00", VA = "0x10911100")]
    private void TapNormalAtk()
    {
    }

    [Token(Token = "0x600C848")]
    [Address(RVA = "0x910710", Offset = "0x90F510", VA = "0x10910710")]
    private void ExecNormalAtk()
    {
    }

    [Token(Token = "0x600C849")]
    [Address(RVA = "0x9106D0", Offset = "0x90F4D0", VA = "0x109106D0")]
    private void SelectDir()
    {
    }

    [Token(Token = "0x600C84A")]
    [Address(RVA = "0x9106D0", Offset = "0x90F4D0", VA = "0x109106D0")]
    private void DestroyMask()
    {
    }

    [Token(Token = "0x600C84B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TutorialMask()
    {
    }

    [Token(Token = "0x2002B9B")]
    public enum eActionType
    {
      [Token(Token = "0x400D626")] MOVE_UNIT,
      [Token(Token = "0x400D627")] ATTACK_TARGET_DESC,
      [Token(Token = "0x400D628")] NORMAL_ATTACK_DESC,
      [Token(Token = "0x400D629")] ABILITY_DESC,
      [Token(Token = "0x400D62A")] TAP_NORMAL_ATTACK,
      [Token(Token = "0x400D62B")] EXEC_NORMAL_ATTACK,
      [Token(Token = "0x400D62C")] SELECT_DIR,
    }

    [Token(Token = "0x2002B9C")]
    public delegate void OpendMethod();
  }
}
