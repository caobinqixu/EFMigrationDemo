﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(SearchServiceDbContext))]
    [Migration("20190215052717_AddContentToBlog")]
    partial class AddContentToBlog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("blog_blog_id");

                    b.Property<bool>("Actived")
                        .HasColumnName("blog_actived");

                    b.Property<string>("Content")
                        .HasColumnName("blog_content");

                    b.Property<string>("Url")
                        .HasColumnName("blog_url");

                    b.HasKey("BlogId");

                    b.ToTable("tbl_blog");
                });

            modelBuilder.Entity("WebApplication1.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("post_post_id");

                    b.Property<bool>("Actived")
                        .HasColumnName("post_actived");

                    b.Property<string>("Content")
                        .HasColumnName("post_content");

                    b.Property<string>("Title")
                        .HasColumnName("post_title");

                    b.HasKey("PostId");

                    b.ToTable("tbl_post");
                });
#pragma warning restore 612, 618
        }
    }
}
