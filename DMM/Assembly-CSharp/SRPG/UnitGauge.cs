// Decompiled with JetBrains decompiler
// Type: SRPG.UnitGauge
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
  [Token(Token = "0x2002C24")]
  [AddComponentMenu("UI/UnitGauge")]
  public class UnitGauge : MonoBehaviour
  {
    [Token(Token = "0x400DA51")]
    [FieldOffset(Offset = "0xC")]
    public GradientGauge MainGauge;
    [Token(Token = "0x400DA52")]
    [FieldOffset(Offset = "0x10")]
    public UnitBuffDisplay BuffDisplay;
    [Token(Token = "0x400DA53")]
    [FieldOffset(Offset = "0x14")]
    public string ModeInt;
    [Token(Token = "0x400DA54")]
    [FieldOffset(Offset = "0x18")]
    public GradientGauge MaxGauge;
    [Token(Token = "0x400DA55")]
    [FieldOffset(Offset = "0x1C")]
    private int mMode;
    [Token(Token = "0x400DA56")]
    [FieldOffset(Offset = "0x20")]
    public GameObject WeakTemplate;
    [Token(Token = "0x400DA57")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ResistTemplate;
    [Token(Token = "0x400DA58")]
    [FieldOffset(Offset = "0x28")]
    public GameObject ElementIcon;
    [Token(Token = "0x400DA59")]
    [FieldOffset(Offset = "0x2C")]
    public Image ElementIconImage;
    [Token(Token = "0x400DA5A")]
    [FieldOffset(Offset = "0x30")]
    public GameObject ElementIconWeakOverlay;
    [Token(Token = "0x400DA5B")]
    [FieldOffset(Offset = "0x34")]
    public GameObject ElementIconResistOverlay;
    [Token(Token = "0x400DA5C")]
    [FieldOffset(Offset = "0x38")]
    private Unit mCurrentUnit;
    [Token(Token = "0x400DA5D")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject ResistWeakPopup;
    [Token(Token = "0x400DA5E")]
    [FieldOffset(Offset = "0x40")]
    [Space(10f)]
    [SerializeField]
    private GameObject GoCondParent;
    [Token(Token = "0x400DA5F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private UnitGaugeCondIcon CondBaseItem;
    [Token(Token = "0x400DA60")]
    [FieldOffset(Offset = "0x48")]
    [Space(10f)]
    [SerializeField]
    private bool twinMode;
    [Token(Token = "0x400DA61")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mReflectionIcon;
    [Token(Token = "0x400DA62")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mAbsorptionIcon;
    [Token(Token = "0x400DA63")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mElemntIcon;
    [Token(Token = "0x400DA64")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject mReflectPhyDamageIcon;
    [Token(Token = "0x400DA65")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject mReflectMagDamageIcon;
    [Token(Token = "0x400DA66")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject[] mReflectElemIcons;
    [Token(Token = "0x400DA67")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject mAbsorptPhyDamageIcon;
    [Token(Token = "0x400DA68")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject mAbsorptMagDamageIcon;
    [Token(Token = "0x400DA69")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject[] mAbsorptElemIcons;
    [Token(Token = "0x400DA6A")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private int ChangeTimerCount;
    [Token(Token = "0x400DA6B")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private float CHANGE_INTERBAL;
    [Token(Token = "0x400DA6C")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private float CHANGE_INTERBAL_SHORT;
    [Token(Token = "0x400DA6D")]
    [FieldOffset(Offset = "0x7C")]
    private List<GameObject> m_DispList;
    [Token(Token = "0x400DA6E")]
    [FieldOffset(Offset = "0x80")]
    private int m_Index;
    [Token(Token = "0x400DA6F")]
    [FieldOffset(Offset = "0x84")]
    private float m_Time;
    [Token(Token = "0x400DA70")]
    [FieldOffset(Offset = "0x88")]
    public List<Unit.UnitManipulate> ChashManipulate;

    [Token(Token = "0x17001B0C")]
    public int Mode
    {
      [Token(Token = "0x600CC52"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600CC53"), Address(RVA = "0x974A00", Offset = "0x973800", VA = "0x10974A00")] set
      {
      }
    }

    [Token(Token = "0x600CC54")]
    [Address(RVA = "0x973A20", Offset = "0x972820", VA = "0x10973A20")]
    private void SetElementIconImage(EElement element, int plus)
    {
    }

    [Token(Token = "0x600CC55")]
    [Address(RVA = "0x972F30", Offset = "0x971D30", VA = "0x10972F30")]
    private void ResetElementIconOverlay()
    {
    }

    [Token(Token = "0x600CC56")]
    [Address(RVA = "0x973C80", Offset = "0x972A80", VA = "0x10973C80")]
    private void ToggleElementIconOverlay(bool weakActive)
    {
    }

    [Token(Token = "0x600CC57")]
    [Address(RVA = "0x9728C0", Offset = "0x9716C0", VA = "0x109728C0")]
    private void ActivateElementIconInternal(bool resetOverlay)
    {
    }

    [Token(Token = "0x600CC58")]
    [Address(RVA = "0x972C60", Offset = "0x971A60", VA = "0x10972C60")]
    private void DeactivateElementIconInternal()
    {
    }

    [Token(Token = "0x600CC59")]
    [Address(RVA = "0x9747A0", Offset = "0x9735A0", VA = "0x109747A0")]
    private void activateHpGauge(bool is_active)
    {
    }

    [Token(Token = "0x600CC5A")]
    [Address(RVA = "0x973C00", Offset = "0x972A00", VA = "0x10973C00")]
    protected void Start()
    {
    }

    [Token(Token = "0x600CC5B")]
    [Address(RVA = "0x973AE0", Offset = "0x9728E0", VA = "0x10973AE0")]
    public void SetOwner(Unit owner)
    {
    }

    [Token(Token = "0x600CC5C")]
    [Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")]
    public Unit GetOwner() => (Unit) null;

    [Token(Token = "0x600CC5D")]
    [Address(RVA = "0x9728C0", Offset = "0x9716C0", VA = "0x109728C0")]
    public void ActivateElementIcon(bool resetOverlay)
    {
    }

    [Token(Token = "0x600CC5E")]
    [Address(RVA = "0x972C60", Offset = "0x971A60", VA = "0x10972C60")]
    public void DeactivateElementIcon()
    {
    }

    [Token(Token = "0x600CC5F")]
    [Address(RVA = "0x972B10", Offset = "0x971910", VA = "0x10972B10")]
    private int CalcElementRate(
      SkillData skill,
      EElement skillElement,
      int skillElemValue,
      Unit attacker)
    {
      return new int();
    }

    [Token(Token = "0x600CC60")]
    [Address(RVA = "0x972D90", Offset = "0x971B90", VA = "0x10972D90")]
    public void OnAttack(
      SkillData skill,
      EElement skillElement,
      int skillElemValue,
      Unit attacker)
    {
    }

    [Token(Token = "0x600CC61")]
    [Address(RVA = "0x972D20", Offset = "0x971B20", VA = "0x10972D20")]
    public void Focus(SkillData skill, EElement skillElement, int skillElemValue, Unit attacker)
    {
    }

    [Token(Token = "0x600CC62")]
    [Address(RVA = "0x974350", Offset = "0x973150", VA = "0x10974350")]
    private void Update()
    {
    }

    [Token(Token = "0x600CC63")]
    [Address(RVA = "0x973E50", Offset = "0x972C50", VA = "0x10973E50")]
    public void UpdateCondIcon(long bad_status_lock)
    {
    }

    [Token(Token = "0x600CC64")]
    [Address(RVA = "0x972980", Offset = "0x971780", VA = "0x10972980")]
    private void AllDisableIcon()
    {
    }

    [Token(Token = "0x600CC65")]
    [Address(RVA = "0x972FA0", Offset = "0x971DA0", VA = "0x10972FA0")]
    public void SetChangeIcon()
    {
    }

    [Token(Token = "0x600CC66")]
    [Address(RVA = "0x974980", Offset = "0x973780", VA = "0x10974980")]
    private bool isDispListAdd(List<GameObject> list, GameObject obj) => new bool();

    [Token(Token = "0x600CC67")]
    [Address(RVA = "0x973CF0", Offset = "0x972AF0", VA = "0x10973CF0")]
    private void UpdateChangeIcon()
    {
    }

    [Token(Token = "0x600CC68")]
    [Address(RVA = "0x974620", Offset = "0x973420", VA = "0x10974620")]
    public UnitGauge()
    {
    }

    [Token(Token = "0x2002C25")]
    public enum GaugeMode
    {
      [Token(Token = "0x400DA72")] Normal,
      [Token(Token = "0x400DA73")] Attack,
      [Token(Token = "0x400DA74")] Target,
      [Token(Token = "0x400DA75")] Change,
    }
  }
}
