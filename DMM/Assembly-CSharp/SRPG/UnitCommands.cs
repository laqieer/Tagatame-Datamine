// Decompiled with JetBrains decompiler
// Type: SRPG.UnitCommands
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BC7")]
  [AddComponentMenu("UI/UnitCommands")]
  public class UnitCommands : MonoBehaviour
  {
    [Token(Token = "0x400D703")]
    private const int DEFAULT_ATTACK_PHY = 0;
    [Token(Token = "0x400D704")]
    private const int DEFAULT_ATTACK_MAG = 1;
    [Token(Token = "0x400D705")]
    [FieldOffset(Offset = "0xC")]
    public UnitCommands.CommandEvent OnCommandSelect;
    [Token(Token = "0x400D706")]
    [FieldOffset(Offset = "0x10")]
    public UnitCommands.YesNoEvent OnYesNoSelect;
    [Token(Token = "0x400D707")]
    [FieldOffset(Offset = "0x14")]
    public UnitCommands.MapExitEvent OnMapExitSelect;
    [Token(Token = "0x400D708")]
    [FieldOffset(Offset = "0x18")]
    public UnitCommands.UnitChgEvent OnUnitChgSelect;
    [Token(Token = "0x400D709")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject MoveButton;
    [Token(Token = "0x400D70A")]
    [FieldOffset(Offset = "0x20")]
    public GameObject AttackButton;
    [Token(Token = "0x400D70B")]
    [FieldOffset(Offset = "0x24")]
    public GameObject RenkeiButton;
    [Token(Token = "0x400D70C")]
    [FieldOffset(Offset = "0x28")]
    public GameObject ItemButton;
    [Token(Token = "0x400D70D")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject MapButton;
    [Token(Token = "0x400D70E")]
    [FieldOffset(Offset = "0x30")]
    public GameObject ExitMapButton;
    [Token(Token = "0x400D70F")]
    [FieldOffset(Offset = "0x34")]
    public GameObject EndButton;
    [Token(Token = "0x400D710")]
    [FieldOffset(Offset = "0x38")]
    public GameObject AbilityButton;
    [Token(Token = "0x400D711")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject GridEventButton;
    [Token(Token = "0x400D712")]
    [FieldOffset(Offset = "0x40")]
    public GameObject OKButton;
    [Token(Token = "0x400D713")]
    [FieldOffset(Offset = "0x44")]
    public GameObject CancelButton;
    [Token(Token = "0x400D714")]
    [FieldOffset(Offset = "0x48")]
    public GameObject UnitChgButton;
    [Token(Token = "0x400D715")]
    [FieldOffset(Offset = "0x4C")]
    public Donuts DonutsBG;
    [Token(Token = "0x400D716")]
    [FieldOffset(Offset = "0x50")]
    public float DonutsAnglePerItem;
    [Token(Token = "0x400D717")]
    [FieldOffset(Offset = "0x54")]
    public float DonutsAngleStart;
    [Token(Token = "0x400D718")]
    [FieldOffset(Offset = "0x58")]
    public string OtherSkillName;
    [Token(Token = "0x400D719")]
    [FieldOffset(Offset = "0x5C")]
    public string OtherSkillIconName;
    [Token(Token = "0x400D71A")]
    [FieldOffset(Offset = "0x60")]
    public string AbilityImageBG;
    [Token(Token = "0x400D71B")]
    [FieldOffset(Offset = "0x64")]
    public string AbilityImageIcon;
    [Token(Token = "0x400D71C")]
    [FieldOffset(Offset = "0x68")]
    public Color AbilityDisableColor;
    [Token(Token = "0x400D71D")]
    [FieldOffset(Offset = "0x78")]
    [HideInInspector]
    private List<GameObject> mAbilityButtons;
    [Token(Token = "0x400D71E")]
    [FieldOffset(Offset = "0x7C")]
    private bool mIsEnableUnitChgButton;
    [Token(Token = "0x400D71F")]
    [FieldOffset(Offset = "0x7D")]
    private bool mIsActiveUnitChgButton;

    [Token(Token = "0x17001AA8")]
    public List<GameObject> AbilityButtons
    {
      [Token(Token = "0x600C954"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (List<GameObject>) null;
      }
    }

    [Token(Token = "0x17001AA9")]
    public UnitCommands.ButtonTypes VisibleButtons
    {
      [Token(Token = "0x600C955"), Address(RVA = "0x94CF40", Offset = "0x94BD40", VA = "0x1094CF40")] set
      {
      }
    }

    [Token(Token = "0x600C956")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C957")]
    [Address(RVA = "0x94C4C0", Offset = "0x94B2C0", VA = "0x1094C4C0")]
    private void SetButtonEvent(GameObject go, UnitCommands.ClickEvent callback)
    {
    }

    [Token(Token = "0x600C958")]
    [Address(RVA = "0x94C680", Offset = "0x94B480", VA = "0x1094C680")]
    private void Start()
    {
    }

    [Token(Token = "0x600C959")]
    [Address(RVA = "0x94BC90", Offset = "0x94AA90", VA = "0x1094BC90")]
    public void EnableUseItem(bool is_no_use_item)
    {
    }

    [Token(Token = "0x600C95A")]
    [Address(RVA = "0x94BD80", Offset = "0x94AB80", VA = "0x1094BD80")]
    public void SetAbilities(AbilityData[] abilities, Unit unit)
    {
    }

    [Token(Token = "0x600C95B")]
    [Address(RVA = "0x94BD50", Offset = "0x94AB50", VA = "0x1094BD50")]
    private void OnSelectAbility(AbilityData ability)
    {
    }

    [Token(Token = "0x600C95C")]
    [Address(RVA = "0x94C590", Offset = "0x94B390", VA = "0x1094C590")]
    private void SortButtons()
    {
    }

    [Token(Token = "0x17001AAA")]
    public bool IsEnableUnitChgButton
    {
      [Token(Token = "0x600C95D"), Address(RVA = "0x94CF30", Offset = "0x94BD30", VA = "0x1094CF30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001AAB")]
    public bool IsActiveUnitChgButton
    {
      [Token(Token = "0x600C95E"), Address(RVA = "0x94CF20", Offset = "0x94BD20", VA = "0x1094CF20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C95F")]
    [Address(RVA = "0x94BBB0", Offset = "0x94A9B0", VA = "0x1094BBB0")]
    public void EnableUnitChgButton(bool is_enable, bool is_active = false)
    {
    }

    [Token(Token = "0x600C960")]
    [Address(RVA = "0x94C340", Offset = "0x94B140", VA = "0x1094C340")]
    public void SetAttackButtonImage(Unit unit)
    {
    }

    [Token(Token = "0x600C961")]
    [Address(RVA = "0x94CEB0", Offset = "0x94BCB0", VA = "0x1094CEB0")]
    public UnitCommands()
    {
    }

    [Token(Token = "0x2002BC8")]
    private delegate void ClickEvent();

    [Token(Token = "0x2002BC9")]
    public delegate void CommandEvent(UnitCommands.CommandTypes command, object data);

    [Token(Token = "0x2002BCA")]
    public delegate void YesNoEvent(bool yes);

    [Token(Token = "0x2002BCB")]
    public delegate void MapExitEvent();

    [Token(Token = "0x2002BCC")]
    public delegate void UnitChgEvent();

    [Token(Token = "0x2002BCD")]
    public enum CommandTypes
    {
      [Token(Token = "0x400D721")] None,
      [Token(Token = "0x400D722")] Move,
      [Token(Token = "0x400D723")] Attack,
      [Token(Token = "0x400D724")] Ability,
      [Token(Token = "0x400D725")] Item,
      [Token(Token = "0x400D726")] Gimmick,
      [Token(Token = "0x400D727")] Map,
      [Token(Token = "0x400D728")] End,
    }

    [Token(Token = "0x2002BCE")]
    [Flags]
    public enum ButtonTypes
    {
      [Token(Token = "0x400D72A")] Move = 1,
      [Token(Token = "0x400D72B")] Action = 2,
      [Token(Token = "0x400D72C")] GridEvent = 4,
      [Token(Token = "0x400D72D")] Misc = 8,
      [Token(Token = "0x400D72E")] Attack = 16, // 0x00000010
      [Token(Token = "0x400D72F")] Skill = 32, // 0x00000020
      [Token(Token = "0x400D730")] Item = 64, // 0x00000040
      [Token(Token = "0x400D731")] IsRenkei = 128, // 0x00000080
      [Token(Token = "0x400D732")] Map = 256, // 0x00000100
    }
  }
}
