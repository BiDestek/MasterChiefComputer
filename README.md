[![LinkedIn][linkedin-shield]][linkedin-url]

<p align="center">
  <a href="https://github.com/BiDestek/MasterChiefComputer">
    <img src="https://github.com/BiDestek/MasterChiefComputer/blob/d6c2e6dec75d7da175ed495db70cbb4289f85246/MasterChiefLogo.png">
    <img src="https://github.com/BiDestek/MasterChiefComputer/blob/d6c2e6dec75d7da175ed495db70cbb4289f85246/MasterChiefLogo2.png">
  </a>
  <h2 align="center">Master Chief Computer E-Commerce Project</h2>
  <h2 align="center">Gaming PC is our bussiness!</h2>
  <p>
    E-commerce Project With N-Layer Architecture.    
  </p>
</p>
    <p> In this project, I created a website backend for e-commerce using Asp.NET Core and RESTful Web API. Customers will be able to register on your site, log in with JWT and take action within their authority.
    </p>

<details open="open">
  <summary><strong>Used Techs</strong></summary>
  <ol>
    <li>
      <a href=" https://github.com/BiDestek/MasterChiefComputer"></a>
	</br>
      <ul>
        <li>Restful Web Api Version .Net Core 6.0.20</li>
      </ul>
      <ul>
        <li>Multi-Layer Architecture</li>
      </ul>
      <ul>
        <li>Interceptors</li>
      </ul>
	<ul>
        <li>Helpers</li>
      </ul>
	<ul>
        <li>IoC</li>
      </ul>      
      <ul>
        <li>Log Aspect(Apache Log4Net)</li>
      </ul>
	<ul>
        <li>Cache Aspect</li>
      </ul>
      <ul>
        <li>Transaction Aspect</li>
      </ul>
      <ul>
        <li>Performance Aspect</li>
      </ul>
      <ul>
        <li>Validation Aspect(Fluent Validation)</li>
      </ul>
      <ul>
        <li>Authorization</li>
      </ul>
      <ul>
        <li>Authentication</li>
      </ul>
      <ul>
        <li>Autofac</li>
      </ul>
      <ul>
        <li>Json Web Token Management</li>
      </ul>
      <ul>
        <li>Async Programing</li>
      </ul>
      <ul>
        <li>Cross Cutting Concerns</li>
      </ul>
      <ul>
        <li>SOLID</li>
      </ul>      
   
## About The Project

### Built With

[![C-Sharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Asp-net](https://img.shields.io/badge/ASP.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet)
[![MSSQL](https://img.shields.io/badge/MSSQL-004880?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server/sql-server-2019?rtc=2)
[![Entity-Framework](https://img.shields.io/badge/Entity%20Framework-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://docs.microsoft.com/en-us/ef/)
[![Autofac](https://img.shields.io/badge/Autofac-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://autofac.org/)
[![Log4Net](https://img.shields.io/badge/Log4Net-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://logging.apache.org/log4net/)
[![Fluent-Validation](https://img.shields.io/badge/Fluent%20Validation-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://fluentvalidation.net/)
</br>

## Tables

<img src="https://github.com/BiDestek/MasterChiefComputer/blob/bfe4ff826a0b8b1836cf630cb0f20839e6233d67/Sql-Database-Diagram.jpg">
  </a>

## Layers

### Business

We write our workloads on this layer. This layer is the layer that will process the data that has been pulled into the project by Data Access. We do not use the Data Access layer directly in our applications. By putting the Business layer together, we make Business do it for us. The data from the user first goes to the Business layer, and then is processed and transferred to the Data Access layer. In addition, data posted by the user passes in this layer with Validation Aspect. In this way, you can prevent cyber attacks and incorrect data entries. In the business tier, we also specify who will access this data. Let's say we want the accounting staff to be able to add to the program database and pull data. however let's just say we want the Accounting Manager to update and delete data from the database. We be able to make such distinctions or controls in the Bussiness layer.

### Core

In this layer, we have base classes that all projects can use in common.

### DataAccess

Only database operations are performed in this layer. The task of this layer is to add, delete, update and extract data from the database. No other action is taken in this layer other than these operations.

### Entities

In this layer, we determine our main classes that we will use throughout the project, so this is where we determine our real objects. Here, we match the objects we have determined with the objects registered in the database.

### WebAPI

Web API Layer that opens the business layer to the internet.

<hr size="3" width="100%" align="left" color="black">

### Contact

Linkedin: [Linkedin Profile](https://www.linkedin.com/in/abdullah-bayram-731171101)

Project Link: [Master Chief Computer E-Commerce Project](https://github.com/BiDestek/MasterChiefComputer)

<hr size="3" width="100%" align="left" color="black">

### Acknowledgements

Bilge Adam - Hakan Şahin



[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/abdullah-bayram-731171101
