# Azure Monitoring Lab

## Overview

This project demonstrates how to deploy and monitor an ASP.NET Core application in Microsoft Azure using Azure Monitor services. The objective was to gain hands-on experience with application observability by configuring monitoring, logging, dashboards, and alerting.

## Objectives

* Deploy an ASP.NET Core web application to Azure App Service
* Configure continuous deployment using GitHub Actions
* Enable Application Insights telemetry
* Monitor application health with Live Metrics
* Query telemetry using Kusto Query Language (KQL)
* Build a custom Azure Workbook dashboard
* Configure Azure Monitor alert rules

---

## Solution Architecture

```
GitHub Repository
        │
        ▼
 GitHub Actions
        │
        ▼
 Azure App Service
        │
        ├────────────► Application Insights
        │                    │
        │                    ├── Live Metrics
        │                    ├── Logs
        │                    ├── Workbooks
        │                    └── Alerts
        │
        ▼
 Azure Dashboard
```

---

## Technologies Used

* ASP.NET Core (.NET 8)
* Azure App Service
* Azure Application Insights
* Azure Monitor
* Azure Workbooks
* Azure Dashboard
* Azure Log Analytics
* GitHub Actions
* Kusto Query Language (KQL)

---

## Deployment Process

The application is deployed automatically using GitHub Actions.

Deployment workflow:

1. Push code to the `main` branch.
2. GitHub Actions restores dependencies and builds the application.
3. The application is published.
4. GitHub Actions deploys the published application to Azure App Service.
5. Azure App Service hosts the application.

---

## Monitoring Configuration

### Application Insights

Application Insights was configured to collect telemetry from the deployed application, including:

* Incoming requests
* Response times
* Exceptions
* Live Metrics
* Application traces

### Azure Monitor Alerts

The following alert rules were created:

* Failed Requests Alert
* High Response Time Alert
* Application Exceptions Alert

These alerts help identify application failures and performance degradation.

---

## Azure Workbook

A custom Azure Workbook was created to visualize application health.

The workbook includes:

* Request volume over time
* Failed request trends
* Average response time

This dashboard provides a centralized view of the application's operational health.

---

## Sample KQL Queries

### Request Count

```kusto
requests
| summarize count() by bin(timestamp, 5m)
```

### Failed Requests

```kusto
requests
| where success == false
| summarize count() by bin(timestamp, 5m)
```

### Average Response Time

```kusto
requests
| summarize avg(duration) by bin(timestamp, 5m)
```

---

## Challenges Encountered

During this project, several deployment and monitoring issues were encountered and resolved, including:

* .NET target framework compatibility issues
* GitHub Actions deployment failures
* Application Insights configuration
* Live Metrics connectivity
* Azure Monitor alert configuration
* KQL query validation

Resolving these issues provided practical experience troubleshooting Azure services and understanding how the monitoring components work together.

---

## Lessons Learned

This project strengthened my understanding of:

* Azure App Service deployment
* Continuous deployment with GitHub Actions
* Azure Application Insights
* Azure Monitor
* Kusto Query Language (KQL)
* Azure Workbooks
* Alert rule configuration
* Application observability best practices

---

## Future Improvements

Possible enhancements include:

* Email notifications using Azure Monitor Action Groups
* Infrastructure as Code using Bicep or Terraform
* Monitoring additional Azure services
* Automated dashboard deployment
* Performance and dependency monitoring
* Centralized monitoring for multiple applications

---

## Conclusion

This project demonstrates the implementation of a complete monitoring solution for an ASP.NET Core application hosted on Azure. It includes automated deployment, application telemetry, centralized dashboards, log analytics, and proactive alerting, providing a solid foundation for monitoring cloud-native applications.
