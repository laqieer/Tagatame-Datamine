// Decompiled with JetBrains decompiler
// Type: SRPG.NotifyList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027BF")]
  [AddComponentMenu("UI/NotifyList")]
  public class NotifyList : MonoBehaviour
  {
    [Token(Token = "0x400BC27")]
    [FieldOffset(Offset = "0x0")]
    private static NotifyList mInstance;
    [Token(Token = "0x400BC28")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform ListParent;
    [Token(Token = "0x400BC29")]
    [FieldOffset(Offset = "0x10")]
    public NotifyListItem Item_Generic;
    [Token(Token = "0x400BC2A")]
    [FieldOffset(Offset = "0x14")]
    public NotifyListItem Item_LoginBonus;
    [Token(Token = "0x400BC2B")]
    [FieldOffset(Offset = "0x18")]
    public NotifyListItem Item_Mission;
    [Token(Token = "0x400BC2C")]
    [FieldOffset(Offset = "0x1C")]
    public NotifyListItem Item_DailyMission;
    [Token(Token = "0x400BC2D")]
    [FieldOffset(Offset = "0x20")]
    public NotifyListItem Item_ContentsUnlock;
    [Token(Token = "0x400BC2E")]
    [FieldOffset(Offset = "0x24")]
    public NotifyListItem Item_QuestSupport;
    [Token(Token = "0x400BC2F")]
    [FieldOffset(Offset = "0x28")]
    public NotifyListItem Item_Award;
    [Token(Token = "0x400BC30")]
    [FieldOffset(Offset = "0x2C")]
    public NotifyListItem Item_MultiInvitation;
    [Token(Token = "0x400BC31")]
    [FieldOffset(Offset = "0x30")]
    public string FadeTrigger;
    [Token(Token = "0x400BC32")]
    [FieldOffset(Offset = "0x34")]
    public float FadeTime;
    [Token(Token = "0x400BC33")]
    [FieldOffset(Offset = "0x38")]
    private List<NotifyListItem> mItems;
    [Token(Token = "0x400BC34")]
    [FieldOffset(Offset = "0x3C")]
    private List<NotifyListItem> mQueue;
    [Token(Token = "0x400BC35")]
    [FieldOffset(Offset = "0x40")]
    public float Lifetime;
    [Token(Token = "0x400BC36")]
    [FieldOffset(Offset = "0x44")]
    public float Spacing;
    [Token(Token = "0x400BC37")]
    [FieldOffset(Offset = "0x48")]
    public float MaxHeight;
    [Token(Token = "0x400BC38")]
    [FieldOffset(Offset = "0x4C")]
    public float Interval;
    [Token(Token = "0x400BC39")]
    [FieldOffset(Offset = "0x50")]
    public float FadeInterval;
    [Token(Token = "0x400BC3A")]
    [FieldOffset(Offset = "0x54")]
    public float GroupSpan;
    [Token(Token = "0x400BC3B")]
    [FieldOffset(Offset = "0x58")]
    private float mStackHeight;
    [Token(Token = "0x400BC3C")]
    [FieldOffset(Offset = "0x5C")]
    private float mGroupTime;
    [Token(Token = "0x400BC3D")]
    [FieldOffset(Offset = "0x60")]
    public string[] DebugItems;
    [Token(Token = "0x400BC3E")]
    [FieldOffset(Offset = "0x4")]
    private static List<string> QueueMsg;

    [Token(Token = "0x17001897")]
    public static bool hasInstance
    {
      [Token(Token = "0x600B282"), Address(RVA = "0x7AA8D0", Offset = "0x7A96D0", VA = "0x107AA8D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001898")]
    public static bool mNotifyEnable
    {
      [Token(Token = "0x600B283"), Address(RVA = "0x7AA960", Offset = "0x7A9760", VA = "0x107AA960")] set
      {
      }
      [Token(Token = "0x600B284"), Address(RVA = "0x7AA930", Offset = "0x7A9730", VA = "0x107AA930")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B285")]
    [Address(RVA = "0x7AA0F0", Offset = "0x7A8EF0", VA = "0x107AA0F0")]
    public static void Push(string msg)
    {
    }

    [Token(Token = "0x600B286")]
    [Address(RVA = "0x7A99F0", Offset = "0x7A87F0", VA = "0x107A99F0")]
    public static void PushQuestSupport(int count, int gold)
    {
    }

    [Token(Token = "0x600B287")]
    [Address(RVA = "0x7A9280", Offset = "0x7A8080", VA = "0x107A9280")]
    public static void PushContentsUnlock(UnlockParam unlock)
    {
    }

    [Token(Token = "0x600B288")]
    [Address(RVA = "0x7A9690", Offset = "0x7A8490", VA = "0x107A9690")]
    public static void PushLoginBonus(ItemData data)
    {
    }

    [Token(Token = "0x600B289")]
    [Address(RVA = "0x7A94A0", Offset = "0x7A82A0", VA = "0x107A94A0")]
    public static void PushDailyTrophy(TrophyParam trophy)
    {
    }

    [Token(Token = "0x600B28A")]
    [Address(RVA = "0x7A9DD0", Offset = "0x7A8BD0", VA = "0x107A9DD0")]
    public static void PushTrophy(TrophyParam trophy)
    {
    }

    [Token(Token = "0x600B28B")]
    [Address(RVA = "0x7A8FE0", Offset = "0x7A7DE0", VA = "0x107A8FE0")]
    public static void PushAward(TrophyParam trophy)
    {
    }

    [Token(Token = "0x600B28C")]
    [Address(RVA = "0x7A9890", Offset = "0x7A8690", VA = "0x107A9890")]
    public static void PushMultiInvitation()
    {
    }

    [Token(Token = "0x600B28D")]
    [Address(RVA = "0x7A9C50", Offset = "0x7A8A50", VA = "0x107A9C50")]
    public static void PushQuestUnlocked(QuestParam quest)
    {
    }

    [Token(Token = "0x600B28E")]
    [Address(RVA = "0x7A8E60", Offset = "0x7A7C60", VA = "0x107A8E60")]
    public static void PushAreaUnlocked(ChapterParam area)
    {
    }

    [Token(Token = "0x600B28F")]
    [Address(RVA = "0x7A9FB0", Offset = "0x7A8DB0", VA = "0x107A9FB0")]
    private bool Push(NotifyListItem item) => new bool();

    [Token(Token = "0x600B290")]
    [Address(RVA = "0x7AA2C0", Offset = "0x7A90C0", VA = "0x107AA2C0")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600B291")]
    [Address(RVA = "0x7A8DE0", Offset = "0x7A7BE0", VA = "0x107A8DE0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B292")]
    [Address(RVA = "0x7A8880", Offset = "0x7A7680", VA = "0x107A8880")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B293")]
    [Address(RVA = "0x7AA330", Offset = "0x7A9130", VA = "0x107AA330")]
    private void Update()
    {
    }

    [Token(Token = "0x600B294")]
    [Address(RVA = "0x7AA7E0", Offset = "0x7A95E0", VA = "0x107AA7E0")]
    public NotifyList()
    {
    }
  }
}
