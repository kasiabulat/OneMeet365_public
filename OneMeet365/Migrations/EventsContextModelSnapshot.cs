﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OneMeet365;
using System;

namespace OneMeet365.Migrations
{
    [DbContext(typeof(EventsContext))]
    partial class EventsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OneMeet365.Atendee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EventCardDataResourceResponseId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EventCardDataResourceResponseId");

                    b.ToTable("Atendee");
                });

            modelBuilder.Entity("OneMeet365.EventCardData", b =>
                {
                    b.Property<string>("ResourceResponseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatorName");

                    b.Property<int?>("EventDataId");

                    b.HasKey("ResourceResponseId");

                    b.HasIndex("EventDataId");

                    b.HasIndex("ResourceResponseId")
                        .IsUnique();

                    b.ToTable("Events");
                });

            modelBuilder.Entity("OneMeet365.OneMeetEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<string>("EventPlace");

                    b.Property<int>("MaxNumberOfPeople");

                    b.Property<string>("MeetingPlace");

                    b.Property<string>("Time");

                    b.HasKey("Id");

                    b.ToTable("OneMeetEvent");
                });

            modelBuilder.Entity("OneMeet365.Atendee", b =>
                {
                    b.HasOne("OneMeet365.EventCardData")
                        .WithMany("Attendees")
                        .HasForeignKey("EventCardDataResourceResponseId");
                });

            modelBuilder.Entity("OneMeet365.EventCardData", b =>
                {
                    b.HasOne("OneMeet365.OneMeetEvent", "EventData")
                        .WithMany()
                        .HasForeignKey("EventDataId");
                });
#pragma warning restore 612, 618
        }
    }
}