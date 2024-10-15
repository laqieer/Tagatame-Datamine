// Decompiled with JetBrains decompiler
// Type: SRPG.GuildAttendanceList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200251F")]
  [FlowNode.Pin(100, "プレイヤー詳細へ", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/Guild/GuildAttendanceList")]
  public class GuildAttendanceList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A9B8")]
    private const int PIN_OUTPUT_OPEN_PLAYER_INFO = 100;
    [Token(Token = "0x400A9B9")]
    [FieldOffset(Offset = "0xC")]
    [Header("現在の出席人数テキスト")]
    [SerializeField]
    private Text CurrentAttendCountText;
    [Token(Token = "0x400A9BA")]
    [FieldOffset(Offset = "0x10")]
    [Header("前日の出席人数テキスト")]
    [SerializeField]
    private Text PrevAttendCountText;
    [Token(Token = "0x400A9BB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Header("出席タイマーテキスト")]
    private Text AttendanceTimerText;
    [Token(Token = "0x400A9BC")]
    [FieldOffset(Offset = "0x18")]
    [Header("ポートメンバーリストの親")]
    [Space(10f)]
    [SerializeField]
    private Transform MemberRoot;
    [Token(Token = "0x400A9BD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Header("ポートメンバーリストアイテムのテンプレート")]
    private GameObject MemberTemplate;
    [Token(Token = "0x400A9BE")]
    [FieldOffset(Offset = "0x20")]
    private DateTime mEndTime;
    [Token(Token = "0x400A9BF")]
    [FieldOffset(Offset = "0x28")]
    private DateTime mElapsedTime;

    [Token(Token = "0x600A330")]
    [Address(RVA = "0x650B10", Offset = "0x64F910", VA = "0x10650B10")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A331")]
    [Address(RVA = "0x651520", Offset = "0x650320", VA = "0x10651520")]
    private void Start()
    {
    }

    [Token(Token = "0x600A332")]
    [Address(RVA = "0x651530", Offset = "0x650330", VA = "0x10651530")]
    private void Update()
    {
    }

    [Token(Token = "0x600A333")]
    [Address(RVA = "0x650F80", Offset = "0x64FD80", VA = "0x10650F80")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A334")]
    [Address(RVA = "0x651290", Offset = "0x650090", VA = "0x10651290")]
    private void SetupMemberList(Dictionary<string, BindViewGuildMemberData> dict)
    {
    }

    [Token(Token = "0x600A335")]
    [Address(RVA = "0x650C30", Offset = "0x64FA30", VA = "0x10650C30")]
    private void RefreshAttendanceTime()
    {
    }

    [Token(Token = "0x600A336")]
    [Address(RVA = "0x650B60", Offset = "0x64F960", VA = "0x10650B60")]
    public void OnClickMemberUnitIcon(GameObject obj)
    {
    }

    [Token(Token = "0x600A337")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A338")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildAttendanceList()
    {
    }
  }
}
