// Decompiled with JetBrains decompiler
// Type: SRPG.ChatUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002169")]
  public class ChatUtility
  {
    [Token(Token = "0x40091D1")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string CHAT_INSPECTION_MASTER_PATH;
    [Token(Token = "0x40091D2")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string CHAT_CHANNEL_MASTER_PATH;

    [Token(Token = "0x6008C7C")]
    [Address(RVA = "0x502BB0", Offset = "0x5019B0", VA = "0x10502BB0")]
    public static bool SetupChatChannelMaster() => new bool();

    [Token(Token = "0x6008C7D")]
    [Address(RVA = "0x502430", Offset = "0x501230", VA = "0x10502430")]
    public static List<ChatUtility.ChatInspectionMaster> LoadInspectionMaster(ref bool is_success)
    {
      return (List<ChatUtility.ChatInspectionMaster>) null;
    }

    [Token(Token = "0x6008C7E")]
    [Address(RVA = "0x502770", Offset = "0x501570", VA = "0x10502770")]
    public static string ReplaceNGWord(
      string _text,
      List<ChatUtility.ChatInspectionMaster> _inspection_datas,
      string _okikae)
    {
      return (string) null;
    }

    [Token(Token = "0x6008C7F")]
    [Address(RVA = "0x501B80", Offset = "0x500980", VA = "0x10501B80")]
    private static string[] GetIllegalWord(string _text) => (string[]) null;

    [Token(Token = "0x6008C80")]
    [Address(RVA = "0x502120", Offset = "0x500F20", VA = "0x10502120")]
    public static ChatUtility.Json_ChatTemplateData LoadChatTemplateMessage()
    {
      return (ChatUtility.Json_ChatTemplateData) null;
    }

    [Token(Token = "0x6008C81")]
    [Address(RVA = "0x5029D0", Offset = "0x5017D0", VA = "0x105029D0")]
    public static void SaveTemplateMessage(ChatUtility.Json_ChatTemplateData new_prefs_data)
    {
    }

    [Token(Token = "0x6008C82")]
    [Address(RVA = "0x5019E0", Offset = "0x5007E0", VA = "0x105019E0")]
    private static ChatUtility.Json_ChatTemplateData CreateNewTemplateMessagePrefsData()
    {
      return (ChatUtility.Json_ChatTemplateData) null;
    }

    [Token(Token = "0x6008C83")]
    [Address(RVA = "0x501A80", Offset = "0x500880", VA = "0x10501A80")]
    private static List<string> GetDefaultTemplateMessageList() => (List<string>) null;

    [Token(Token = "0x6008C84")]
    [Address(RVA = "0x502010", Offset = "0x500E10", VA = "0x10502010")]
    public static bool IsMultiQuestNow() => new bool();

    [Token(Token = "0x6008C85")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatUtility()
    {
    }

    [Token(Token = "0x6008C86")]
    [Address(RVA = "0x502EC0", Offset = "0x501CC0", VA = "0x10502EC0")]
    static ChatUtility()
    {
    }

    [Token(Token = "0x200216A")]
    public class Json_ChatInspectionMaster
    {
      [Token(Token = "0x40091D3")]
      [FieldOffset(Offset = "0x8")]
      public ChatUtility.JSON_ChatInspectionMaster[] chatinspections;

      [Token(Token = "0x6008C87")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ChatInspectionMaster()
      {
      }
    }

    [Token(Token = "0x200216B")]
    public class JSON_ChatInspectionMaster
    {
      [Token(Token = "0x40091D4")]
      [FieldOffset(Offset = "0x8")]
      public int pk;
      [Token(Token = "0x40091D5")]
      [FieldOffset(Offset = "0xC")]
      public ChatUtility.JSON_ChatInspectionMaster.Fields fields;

      [Token(Token = "0x6008C88")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_ChatInspectionMaster()
      {
      }

      [Token(Token = "0x200216C")]
      public class Fields
      {
        [Token(Token = "0x40091D6")]
        [FieldOffset(Offset = "0x8")]
        public int id;
        [Token(Token = "0x40091D7")]
        [FieldOffset(Offset = "0xC")]
        public string ngword;
        [Token(Token = "0x40091D8")]
        [FieldOffset(Offset = "0x10")]
        public int reflection;

        [Token(Token = "0x6008C89")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Fields()
        {
        }
      }
    }

    [Token(Token = "0x200216D")]
    public class ChatInspectionMaster
    {
      [Token(Token = "0x40091D9")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x40091DA")]
      [FieldOffset(Offset = "0xC")]
      public string word;
      [Token(Token = "0x40091DB")]
      [FieldOffset(Offset = "0x10")]
      public bool reflection;

      [Token(Token = "0x6008C8A")]
      [Address(RVA = "0x4FCBC0", Offset = "0x4FB9C0", VA = "0x104FCBC0")]
      public bool Deserialize(ChatUtility.JSON_ChatInspectionMaster json) => new bool();

      [Token(Token = "0x6008C8B")]
      [Address(RVA = "0x4FCC20", Offset = "0x4FBA20", VA = "0x104FCC20")]
      public ChatInspectionMaster()
      {
      }
    }

    [Token(Token = "0x200216E")]
    public class Json_ChatTemplateData
    {
      [Token(Token = "0x40091DC")]
      [FieldOffset(Offset = "0x8")]
      public string[] messages;

      [Token(Token = "0x6008C8C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ChatTemplateData()
      {
      }
    }

    [Token(Token = "0x200216F")]
    public class RoomMemberManager
    {
      [Token(Token = "0x40091DD")]
      [FieldOffset(Offset = "0x8")]
      private ChatUtility.RoomMember tmp_entry_member;
      [Token(Token = "0x40091DE")]
      [FieldOffset(Offset = "0xC")]
      private PhotonPlayerParameter tmp_leave_member;
      [Token(Token = "0x40091DF")]
      [FieldOffset(Offset = "0x10")]
      private List<ChatUtility.RoomMember> room_members;
      [Token(Token = "0x40091E0")]
      [FieldOffset(Offset = "0x14")]
      private List<ChatUtility.RoomMember> entry_members;
      [Token(Token = "0x40091E1")]
      [FieldOffset(Offset = "0x18")]
      private List<ChatUtility.RoomMember> leave_members;

      [Token(Token = "0x170013D1")]
      public List<ChatUtility.RoomMember> RoomMembers
      {
        [Token(Token = "0x6008C8D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (List<ChatUtility.RoomMember>) null;
        }
      }

      [Token(Token = "0x170013D2")]
      public List<ChatUtility.RoomMember> EntryMembers
      {
        [Token(Token = "0x6008C8E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (List<ChatUtility.RoomMember>) null;
        }
      }

      [Token(Token = "0x170013D3")]
      public List<ChatUtility.RoomMember> LeaveMembers
      {
        [Token(Token = "0x6008C8F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return (List<ChatUtility.RoomMember>) null;
        }
      }

      [Token(Token = "0x6008C90")]
      [Address(RVA = "0x50AA90", Offset = "0x509890", VA = "0x1050AA90")]
      public RoomMemberManager()
      {
      }

      [Token(Token = "0x6008C91")]
      [Address(RVA = "0x50A4A0", Offset = "0x5092A0", VA = "0x1050A4A0")]
      public void Refresh(List<PhotonPlayerParameter> _new_players)
      {
      }

      [Token(Token = "0x6008C92")]
      [Address(RVA = "0x50A440", Offset = "0x509240", VA = "0x1050A440")]
      public void Clear()
      {
      }
    }

    [Token(Token = "0x2002173")]
    public class RoomMember
    {
      [Token(Token = "0x40091E8")]
      [FieldOffset(Offset = "0x8")]
      private int photon_player_id;
      [Token(Token = "0x40091E9")]
      [FieldOffset(Offset = "0xC")]
      private int player_id;
      [Token(Token = "0x40091EA")]
      [FieldOffset(Offset = "0x10")]
      private string uid;
      [Token(Token = "0x40091EB")]
      [FieldOffset(Offset = "0x14")]
      private string name;

      [Token(Token = "0x170013D4")]
      public int PhotonPlayerId
      {
        [Token(Token = "0x6008C98"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170013D5")]
      public int PlayerId
      {
        [Token(Token = "0x6008C99"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170013D6")]
      public string UID
      {
        [Token(Token = "0x6008C9A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x170013D7")]
      public string Name
      {
        [Token(Token = "0x6008C9B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6008C9C")]
      [Address(RVA = "0x50AB60", Offset = "0x509960", VA = "0x1050AB60")]
      public void SetParam(int _photon_player_id, int _player_id, string _uid, string _name)
      {
      }

      [Token(Token = "0x6008C9D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RoomMember()
      {
      }
    }

    [Token(Token = "0x2002174")]
    public class RoomInfo
    {
      [Token(Token = "0x40091EC")]
      [FieldOffset(Offset = "0x8")]
      private ChatWindow chat_window;
      [Token(Token = "0x40091ED")]
      [FieldOffset(Offset = "0xC")]
      private bool is_active;
      [Token(Token = "0x40091EE")]
      [FieldOffset(Offset = "0x10")]
      private QuestParam quest_param;

      [Token(Token = "0x170013D8")]
      public bool IsActive
      {
        [Token(Token = "0x6008C9E"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170013D9")]
      public QuestParam QuestParam
      {
        [Token(Token = "0x6008C9F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (QuestParam) null;
        }
      }

      [Token(Token = "0x6008CA0")]
      [Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")]
      public void Init(ChatWindow _chat_window)
      {
      }

      [Token(Token = "0x6008CA1")]
      [Address(RVA = "0x50A3E0", Offset = "0x5091E0", VA = "0x1050A3E0")]
      private void SetParam(string _iname)
      {
      }

      [Token(Token = "0x6008CA2")]
      [Address(RVA = "0x50A3D0", Offset = "0x5091D0", VA = "0x1050A3D0")]
      public void Run()
      {
      }

      [Token(Token = "0x6008CA3")]
      [Address(RVA = "0x50A250", Offset = "0x509050", VA = "0x1050A250")]
      private void Refresh()
      {
      }

      [Token(Token = "0x6008CA4")]
      [Address(RVA = "0x50A240", Offset = "0x509040", VA = "0x1050A240")]
      public void ExitRoom()
      {
      }

      [Token(Token = "0x6008CA5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RoomInfo()
      {
      }
    }
  }
}
