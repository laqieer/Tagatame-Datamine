// Decompiled with JetBrains decompiler
// Type: SRPG.LevelLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026BF")]
  [RequireComponent(typeof (Selectable))]
  [AddComponentMenu("UI/LevelLock")]
  public class LevelLock : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
  {
    [Token(Token = "0x400B5BE")]
    [FieldOffset(Offset = "0x0")]
    private static List<LevelLock> mInstances;
    [Token(Token = "0x400B5BF")]
    [FieldOffset(Offset = "0x10")]
    [HideInInspector]
    public long Condition;
    [Token(Token = "0x400B5C0")]
    [FieldOffset(Offset = "0x18")]
    public Text ConditionText;
    [Token(Token = "0x400B5C1")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ShowLocked;
    [Token(Token = "0x400B5C2")]
    [FieldOffset(Offset = "0x20")]
    public GameObject ShowUnlocked;
    [Token(Token = "0x400B5C3")]
    [FieldOffset(Offset = "0x24")]
    public bool ToggleInteractable;
    [Token(Token = "0x400B5C4")]
    [FieldOffset(Offset = "0x28")]
    public GameObject ReleaseStoryPart;
    [Token(Token = "0x400B5C5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Animator UnlockAnimator;
    [Token(Token = "0x400B5C6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool UnlockAnimationOnStart;
    [Token(Token = "0x400B5C7")]
    [FieldOffset(Offset = "0x34")]
    private int mUnlockLevel;
    [Token(Token = "0x400B5C8")]
    [FieldOffset(Offset = "0x38")]
    private int mUnlockVipRank;

    [Token(Token = "0x1700180D")]
    public UnlockTargets condition
    {
      [Token(Token = "0x600AD59"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new UnlockTargets();
      }
      [Token(Token = "0x600AD5A"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] set
      {
      }
    }

    [Token(Token = "0x600AD5B")]
    [Address(RVA = "0x7140A0", Offset = "0x712EA0", VA = "0x107140A0")]
    public static void UpdateLockStates()
    {
    }

    [Token(Token = "0x600AD5C")]
    [Address(RVA = "0x713890", Offset = "0x712690", VA = "0x10713890")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600AD5D")]
    [Address(RVA = "0x713820", Offset = "0x712620", VA = "0x10713820")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600AD5E")]
    [Address(RVA = "0x713D60", Offset = "0x712B60", VA = "0x10713D60")]
    private void Start()
    {
    }

    [Token(Token = "0x600AD5F")]
    [Address(RVA = "0x713E30", Offset = "0x712C30", VA = "0x10713E30", Slot = "5")]
    public virtual void UpdateLockState()
    {
    }

    [Token(Token = "0x600AD60")]
    [Address(RVA = "0x713B10", Offset = "0x712910", VA = "0x10713B10")]
    public static bool ShowLockMessage(int playerLv, int playerVipRank, UnlockTargets target)
    {
      return new bool();
    }

    [Token(Token = "0x600AD61")]
    [Address(RVA = "0x713BE0", Offset = "0x7129E0", VA = "0x10713BE0")]
    public static bool ShowLockMessage(
      int playerLv,
      int reqLv,
      int vipRank,
      int reqVipRank,
      UnlockParam unlock_param)
    {
      return new bool();
    }

    [Token(Token = "0x600AD62")]
    [Address(RVA = "0x713280", Offset = "0x712080", VA = "0x10713280")]
    public static string CreateUnlockCondsText_Quest(UnlockParam unlock_param) => (string) null;

    [Token(Token = "0x600AD63")]
    [Address(RVA = "0x713520", Offset = "0x712320", VA = "0x10713520")]
    public static UnlockTargets GetTargetByQuestId(string quest_id, UnlockTargets default_value)
    {
      return new UnlockTargets();
    }

    [Token(Token = "0x600AD64")]
    [Address(RVA = "0x713630", Offset = "0x712430", VA = "0x10713630")]
    public static bool IsNeedCheckUnlockConds(QuestParam quest_param) => new bool();

    [Token(Token = "0x600AD65")]
    [Address(RVA = "0x713670", Offset = "0x712470", VA = "0x10713670")]
    public static bool IsPlayableQuest(QuestParam quest_param) => new bool();

    [Token(Token = "0x600AD66")]
    [Address(RVA = "0x713900", Offset = "0x712700", VA = "0x10713900", Slot = "6")]
    public virtual void OnPointerClick(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600AD67")]
    [Address(RVA = "0x714150", Offset = "0x712F50", VA = "0x10714150")]
    private IEnumerator WaitUnlockAnimation() => (IEnumerator) null;

    [Token(Token = "0x600AD68")]
    [Address(RVA = "0x713A70", Offset = "0x712870", VA = "0x10713A70")]
    private IEnumerator PlayUnlockAnimationAuto(LevelLock.OnUnlockAnimationEnd callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600AD69")]
    [Address(RVA = "0x713AE0", Offset = "0x7128E0", VA = "0x10713AE0")]
    public void PlayUnlockAnimation(LevelLock.OnUnlockAnimationEnd callback)
    {
    }

    [Token(Token = "0x600AD6A")]
    [Address(RVA = "0x713460", Offset = "0x712260", VA = "0x10713460")]
    public bool GetIsUnlockAnimationPlayable() => new bool();

    [Token(Token = "0x600AD6B")]
    [Address(RVA = "0x68C140", Offset = "0x68AF40", VA = "0x1068C140")]
    public LevelLock()
    {
    }

    [Token(Token = "0x600AD6C")]
    [Address(RVA = "0x7141C0", Offset = "0x712FC0", VA = "0x107141C0")]
    static LevelLock()
    {
    }

    [Token(Token = "0x20026C0")]
    public delegate void OnUnlockAnimationEnd(UnlockTargets condition);
  }
}
